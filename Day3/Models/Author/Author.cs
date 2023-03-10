namespace Day3
{
    public class Author
    {
        public int ID { set; get; }
        public string Author_Name {  set ; get; }

        public List<Book> Books { set; get; } = new List<Book>();

    }
}
