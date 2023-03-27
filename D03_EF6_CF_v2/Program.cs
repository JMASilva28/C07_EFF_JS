
// T-SQL DML: data manipulation language --> SELECT, INSERT, UPDATE, DELETE

// CRUD Operations: CREATE, READ, UPDATE, DELETE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using D00_Utility;
using D03_EF6_CF_v2.Model;

namespace D03_EF6_CF_v2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Utility.SetUnicodeConsole();

            BlogRepository.CreateBlog("Java");
            BlogRepository.ReadBlog();

            PostRepository.CreatPost(3);
            PostRepository.ReadPost();

            Utility.TerminateConsole();


        }
    }
}
