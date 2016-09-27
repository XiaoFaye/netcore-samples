using Microsoft.EntityFrameworkCore;
using ConsoleApplication.Models;

namespace ConsoleApplication.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { set; get; }

        public DbSet<Book> Books { set; get; }

        public DbSet<BookType> BookTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(@"Data Source=192.168.1.1;Initial Catalog=ef;User ID=sa;Password=pw");
    }
}