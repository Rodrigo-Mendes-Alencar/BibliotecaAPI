namespace ApiSolo.Model
{
    public class Book
    {
        public int id { get;  private set; }
        public string title {get;set; }
        public string? author { get; set; }
        public bool isborrowed { get;set; }

        public Book()
        {
        }

        public Book(string title, string author, bool isborrowed)
        {
            this.title = title;
            this.author = author;
            this.isborrowed = isborrowed;
        }
    }
}
