using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MoviestoreApp.NewDb
{
    public class MoviestoreContext : DbContext
    {
        public DbSet<Moviestoretbl> Moviestores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.MoviestoreApp.NewDb;Trusted_Connection=True;");
        }
    }

    public class Moviestoretbl
    {
        [Key]
        public int MoviestoreId { get; set; }
        public string title { get; set; }
        public string year { get; set; }
        public string category_name { get; set; }
    }


}