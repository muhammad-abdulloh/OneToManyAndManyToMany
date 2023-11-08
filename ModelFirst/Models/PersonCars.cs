using System.ComponentModel.DataAnnotations.Schema;

namespace ModelFirst.Models
{
    public class PersonCars
    {
        public int Id { get; set; }

        public int PersonRustamId { get; set; }
        public int CarRustamId { get; set; }


        [ForeignKey("PersonRustamId")]
        public Person Persons { get; set; }

        [ForeignKey("CarRustamId")]
        public Car Cars { get; set; }
    }
}
