using D00_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D03_EF6_CF_v2.Model
{
    public static class PostRepository
    {

        #region Methods
        public static void CreatPost(int blogId)
        {
            using (var db = new BlogContext())
            {
                IList<Post> posts = new List<Post>
                {
                    new Post {BlogID = blogId, Title = "t1", Content = "c1"},
                    new Post {BlogID = blogId, Title = "t1", Content = "c1"},
                    new Post {BlogID = blogId, Title = "t1", Content = "c1"}
                };

                db.Post.AddRange(posts);        // Evita ter de se fazer um a um 
                db.SaveChanges();

            }
        }

        public static void ReadPost()
        {
            using (var db = new BlogContext())
            {
                var queryPosts = db.Post.Select(p => p).OrderBy(p => p.Title);

                Utility.BlockSeparator("\n\n\n");
                Utility.WriteTitle("Posts");
                queryPosts.ToList().ForEach(p => Utility.WriteMessage($"{p.PostID} - {p.Title}"));

            }
        }
        #endregion


    }
}
