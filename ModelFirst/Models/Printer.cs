namespace ModelFirst.Models
{
    public class Printer
    {
        public Printer()
        {
            Books = new HashSet<Book>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
