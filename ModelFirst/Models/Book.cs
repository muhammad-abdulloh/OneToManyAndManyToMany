namespace ModelFirst.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Printer Printers { get; set; }    

    }
}
