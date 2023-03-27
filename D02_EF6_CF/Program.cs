
// T-SQL DML: data manipulation language --> SELECT, INSERT, UPDATE, DELETE

// CRUD Operations: CREATE, READ, UPDATE, DELETE

using D03_EF6_CF_v2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;

namespace D03_EF6_CF_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            using (var db = new BlogContext())  // Instanciar a bd 
            {

                #region Blog

                // Criar e gravar um novo Blog
                Blog blog01 = new Blog();

                //blog01.BlogId = 1; -- não é preciso como é PK identity vai auto numerar.
                blog01.Name = "FF6";

                db.Blog.Add(blog01);
                db.SaveChanges();

                var queryBlogs = db.Blog.Select(b => b).OrderBy(b => b.Name);

                Utility.WriteTitle("Blogs");

                queryBlogs.ToList().ForEach(b => Utility.WriteMessage($"{b.BlogId} - {b.Name}", "", "\n"));
                #endregion

                #region Post

                Post post01 = new Post();
                Post post02 = new Post();
                Post post03 = new Post();

                
                post01.Title = "AB";
                post01.Content = "abb";
                post01.BlogId = 1;
                
                post02.Title = "BC";
                post02.Content = "bcc";
                post02.BlogId = 1;
               
                post03.Title = "CD";
                post03.Content = "cdd";
                post03.BlogId = 1;

                db.Post.Add(post01);
                db.Post.Add(post02);
                db.Post.Add(post03);

                db.SaveChanges();

                var queryPosts = db.Post.Select(p => p).OrderBy(p => p.Title);

                Utility.WriteTitle("Post");

                queryPosts.ToList().ForEach(p => Utility.WriteMessage($"{p.BlogId} - {p.PostId}", "", "\n"));
                #endregion

            }

            Utility.TerminateConsole();


        }
    }
}
