using Day3.Models;

namespace Day3
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Author_Id { set; get; }

        public Author Author { get; set; }

        public List<BookImages> BookImages { get; set; } = new List<BookImages>();
    }
}
