using System;

namespace MoviestoreApp.NewDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MoviestoreContext())
            {
                Console.WriteLine("Please Enter the movie Title");
                string title = Console.ReadLine();
                Console.WriteLine("Please Enter the movie Year");
                string year = Console.ReadLine();
                Console.WriteLine("Please Enter the movie Category");
                string category = Console.ReadLine();

                db.Moviestores.Add(new Moviestoretbl { title = title });
                db.Moviestores.Add(new Moviestoretbl { year = year });
                db.Moviestores.Add(new Moviestoretbl { category_name = category });
                var count = db.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.WriteLine();
                Console.WriteLine("All Movies in database:");
                foreach (var Moviestoretbl in db.Moviestores)
                {
                    Console.WriteLine(" * {0}{1}{2}", Moviestoretbl.title, Moviestoretbl.year, Moviestoretbl.category_name);
                }
            }
        }
    }
}