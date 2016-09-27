using ConsoleApplication.Data;
using ConsoleApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new DataContext())
            {
                context.Database.EnsureCreated();
                var bt1 = new BookType { Name = "Fiction" };
                var bt2 = new BookType { Name = "Health" };
                var author1 = new Author { Name = "Author 1", Email = "hello1@gmail.com" };
                var author2 = new Author { Name = "Author 2", Email = "hello2@gmail.com" };

                var book1 = new Book { Title = "Back to the Future.", BookType = bt1, Author = author2 };
                var book2 = new Book { Title = "How to keep fit", BookType = bt2, Author = author1 };

                context.Add(bt1);
                context.Add(bt2);
                context.Add(author1);
                context.Add(author2);
                context.Add(book1);
                context.Add(book2);

                context.SaveChanges();
            }

            return View();
        }
    }
}