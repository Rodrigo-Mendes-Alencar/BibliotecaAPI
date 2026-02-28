namespace ApiSolo.Model
{
    public class Book
    {
        public int id { get; private set; }
        public string title {get; private set; }
        public string? author { get; private set; }
        public bool isborrowed { get; private set; }

        public Book(string title, string author, bool isborrowed)
        {
            this.title = title;
            this.author = author;
            this.isborrowed = isborrowed;
        }
    }
}
