using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo2 {
  class Program {
    static void Main(string[] args) {

      //添加博客
      int newBlogId = 0;
      int newPostId = 0;
      using (var context = new BloggingContext()) {
        var blog = new Blog { Url = "http://sample.com", Rating = 3 };
        blog.Posts = new List<Post>() {
          new Post() { Title = "Test1", Content = "Hello"},
          new Post() { Title = "Test2", Content = "Hello"}
        };
        context.Blogs.Add(blog);
        context.SaveChanges();
        newBlogId = blog.BlogId;
      }

      //添加帖子
      using (var context = new BloggingContext()) {
        var post = new Post() { Title = "Test3",
          Content = "Hell0", BlogId = newBlogId
        };
        context.Entry(post).State = EntityState.Added;
        context.SaveChanges();
        newPostId = post.PostId;
      }

      //根据Id查找博客
      using (var context = new BloggingContext()) {
        var blog = context.Blogs
            .SingleOrDefault(b => b.BlogId == newBlogId);
        if(blog!=null) Console.WriteLine(blog.Url);
      }


      //查询评分大于1的博客（包括所有帖子）
      using (var context = new BloggingContext()) {
        var query = context.Blogs.Include("Posts")
            .Where(b => b.Rating > 1)
            .OrderBy(b => b.Url);
        foreach (var b in query) {
          Console.WriteLine(b.BlogId);
        }
      }

      //查询Url为"http://sample.com"的博客的所有帖子
      using (var context = new BloggingContext()) {
        var query = context.Posts
            .Where(p => p.Blog.Url == "http://sample.com")
            .OrderBy(p => p.Title);
        foreach (var p in query) {
          Console.WriteLine(p.Title);
        }
      }

      //修改Id为newPostId的帖子(方法1)
      using (var context = new BloggingContext()) {
        var post = new Post() { PostId = newPostId, Title = "Test3",
          Content = "Hello world", BlogId = newBlogId,Comment = "just a test！" };
        context.Entry(post).State = EntityState.Modified;
        context.SaveChanges();
      }


      //修改Id为newPostId的帖子（方法2）
      using (var context = new BloggingContext()) {
        var post = context.Posts.FirstOrDefault(p => p.PostId == newPostId);
        if (post != null) {
          post.Content = "Hello world,EF!";
          post.Comment = "EF test！";
          context.SaveChanges();
        }
      }

      //多个操作一起提交(自动形成一个事务)
      using (var context = new BloggingContext()) {
        // add
        context.Blogs.Add(new Blog { Url = "http://example.com/blog_one" });
        context.Blogs.Add(new Blog { Url = "http://example.com/blog_two" });
        // update
        var firstBlog = context.Blogs.FirstOrDefault(b=>b.BlogId==newBlogId);
        if (firstBlog != null) firstBlog.Url = "http://example.com/blog_three";
        context.SaveChanges();
      }


      //删除Id为newPostId的帖子
      using (var context = new BloggingContext()) {
        var post = context.Posts.FirstOrDefault(p => p.PostId == newPostId);
        if (post != null) {
          context.Posts.Remove(post);
          context.SaveChanges();
        }
      }

      //删除Id为blogId的博客及其帖子
      using (var context = new BloggingContext()) {
        var blog = context.Blogs.Include(b=>b.Posts).FirstOrDefault(p => p.BlogId == newBlogId);
        if (blog != null) {
          context.Blogs.Remove(blog);
          context.SaveChanges();
        }
      }

      Console.ReadKey();
    }
  }



}
