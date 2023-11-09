using Microsoft.Identity.Client;

namespace ModelFirst.Models.MyModels
{
    public class Menu
    {
        public Menu()
        {
             Children = new HashSet<Menu>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public int? ParentId { get; set; }

        public Menu Parent { get; set; }

        public ICollection<Menu> Children { get; set;}
    }
}
