namespace ModelFirst.Models
{
    public class Company
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        
        public ICollection<User?> Users { get; set; }
    }
}
