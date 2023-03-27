using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_CF_v2.Model
{
    public static class BlogRepository
    {

        #region Methods
        public static void CreateBlog(string blogName)
        {

            using (var db = new BlogContext())
            {
                Blog blog = new Blog { Name = blogName };

                db.Blog.Add(blog);
                db.SaveChanges();
            }

        }

        public static void ReadBlog()
        {
            using (var db = new BlogContext())
            {
                var queryBlogs = db.Blog.Select(b => b).OrderBy(b => b.Name);

                Utility.WriteTitle("Blogs");

                queryBlogs.ToList().ForEach(b => Utility.WriteMessage($"{b.BlogID} - {b.Name}"));
            }
        }

        #endregion
    }
}
