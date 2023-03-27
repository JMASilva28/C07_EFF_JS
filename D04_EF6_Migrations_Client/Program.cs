using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04_EF6_Migrations_Client
{

    internal class Program
    {

        static void Main(string[] args)
        {

            BooksDBClient.CreatePublisher();
            BooksDBClient.CreateBook();

            Console.Write("Data entered successfully.");

            Console.ReadKey();

        }

    }

}
