namespace ModelFirst.Models.External
{
    public class FluentClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public bool IsDeleted { get; set; }
    }
}
