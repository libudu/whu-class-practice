using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TodoApi.Models;

namespace BlogApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {

        private readonly TodoContext todoDb;

        //构造函数把TodoContext 作为参数，Asp.net core 框架可以自动注入TodoContext对象
        public TodoController(TodoContext context)
        {
            this.todoDb = context;
        }

        // GET: api/todo/{id}  id为路径参数
        [HttpGet("{id}")]
        public ActionResult<TodoItem> GetTodoItem(long id)
        {
            var todoItem = todoDb.TodoItems.FirstOrDefault(t => t.Id == id);
            if (todoItem == null)
            {
                return NotFound();
            }
            return todoItem;
        }

        // GET: api/todo
        // GET: api/todo/pageQuery?name=课程&&isComplete=true
        [HttpGet]
        public ActionResult<List<TodoItem>> GetTodoItems(string name, bool? isComplete)
        {
            var query = buildQuery(name, isComplete);
            return query.ToList();
        }

        // GET: api/todo/pageQuery?skip=5&&take=10  
        // GET: api/todo/pageQuery?name=课程&&isComplete=true&&skip=5&&take=10
        [HttpGet("pageQuery")]
        public ActionResult<List<TodoItem>> queryTodoItem(string name, bool? isComplete, int skip, int take)
        {
            var query = buildQuery(name, isComplete).Skip(skip).Take(take);
            return query.ToList();
        }

        private IQueryable<TodoItem> buildQuery(string name, bool? isComplete)
        {
            IQueryable<TodoItem> query = todoDb.TodoItems;
            if (name != null)
            {
                query = query.Where(t => t.Name.Contains(name));
            }
            if (isComplete != null)
            {
                query = query.Where(t => t.IsComplete == isComplete);
            }
            return query;
        }


        // POST: api/todo
        [HttpPost]
        public ActionResult<TodoItem> PostTodoItem(TodoItem todo)
        {
            try
            {
                todoDb.TodoItems.Add(todo);
                todoDb.SaveChanges();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return todo;
        }

        // PUT: api/todo/{id}
        [HttpPut("{id}")]
        public ActionResult<TodoItem> PutTodoItem(long id, TodoItem todo)
        {
            if (id != todo.Id)
            {
                return BadRequest("Id cannot be modified!");
            }
            try
            {
                todoDb.Entry(todo).State = EntityState.Modified;
                todoDb.SaveChanges();
            }
            catch (Exception e)
            {
                string error = e.Message;
                if (e.InnerException != null) error = e.InnerException.Message;
                return BadRequest(error);
            }
            return NoContent();
        }

        // DELETE: api/todo/{id}
        [HttpDelete("{id}")]
        public ActionResult DeleteTodoItem(long id)
        {
            try
            {
                var todo = todoDb.TodoItems.FirstOrDefault(t => t.Id == id);
                if (todo != null)
                {
                    todoDb.Remove(todo);
                    todoDb.SaveChanges();
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }
            return NoContent();
        }

    }
}