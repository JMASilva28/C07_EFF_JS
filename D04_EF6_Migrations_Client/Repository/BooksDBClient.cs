using D04_EF6_Migrations_DAL;

namespace D04_EF6_Migrations_Client
{

    static class BooksDBClient
    {

        public static void CreatePublisher()
        {

            Publisher publisher = new Publisher
            {
                Name = "New publisher"
            };

            using (var context = new BookDBContext())
            {
                context.Publisher.Add(publisher);
                context.SaveChanges();
            }

        }

        public static void CreateBook()
        {

            Book book = new Book
            {
                PublisherID = 1,
                Title = "New book",
                ISBN = "123456789"
            };

            using (var context = new BookDBContext())
            {
                context.Book.Add(book);
                context.SaveChanges();
            }

        }

    }

}
