using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo2 {

  public class Blog {

    [Key,Column(Order =1)]
    public int BlogId { get; set; }//自动识别为主键
    [Required]
    public string Url { get; set; }
    public int Rating { get; set; }
    public List<Post> Posts { get; set; } //一对多关联
  }

  public class Post {
    public int PostId { get; set; }//自动识别为主键
    [Required]
    public string Title { get; set; }
    [Required]
    public string Content { get; set; }
    public string Comment { get; set; }

    public int BlogId { get; set; } //自动识别为外键
    public Blog Blog { get; set; }  //多对一关联
  }

}
