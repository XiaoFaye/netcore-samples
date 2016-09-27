namespace ConsoleApplication.Models
{
    public class Book
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public int BookTypeId { set; get; }
        public virtual BookType BookType { get; set; }

        public int AuthorId { set; get; }
        public virtual Author Author { set; get; }
    }

    public class BookType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
    }
}