using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public static class Seeder
    {
        public static void InitialSeed()
        {
            using (var context = new BlogContext())
            {
                List<Post> pst = new List<Post>();
                List<Post> pst1 = new List<Post>();
                if (!context.Blogs.Any())
                {

                    Blog blog = new Blog
                    {
                        Name = "Кулинария от Василия",
                        Author = "Vasya@mail.com",
                        DateCreate = DateTime.Now.AddYears(-3)
                    };
                    context.Blogs.Add(blog);

                    Blog blog1 = new Blog
                    {
                        Name = "Лайфхаки от гусько",
                        Author = "Gusbkowww@mail.com",
                        DateCreate = DateTime.Now.AddDays(-41)
                    };
                    context.Blogs.Add(blog1);


                    pst1.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst1.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst1.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst1.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst1.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Вася-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    blog1.Posts = pst1;
                    Blog blog2 = new Blog
                    {
                        Name = "Калина 2 спорт мега хорош",
                        Author = "Dima@mail.com",
                        DateCreate = DateTime.Now.AddDays(-42)
                    };
                    context.Blogs.Add(blog2);
                    pst.Clear();
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    pst.Add(new Post
                    {
                        Name = "О себе",
                        Text = "Всем привет, я Дима-повар! В этом блоге я расскажу вам о многих интересных рецептах",
                        PostTime = DateTime.Now.AddDays(-41)
                    });
                    blog2.Posts = pst;
                    context.SaveChanges();
                }

                
            }
        }
    }     
}
