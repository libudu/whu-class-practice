using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext{
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options){
            this.Database.EnsureCreated(); //自动建库建表
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}