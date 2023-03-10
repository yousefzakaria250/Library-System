using Day3.Models.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace Day3.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Get()
        {
            LibraryContext context 
                = new LibraryContext();
            var books = 
            context.Books.ToList();
            return View("Get" , books);
        }
    }
}
