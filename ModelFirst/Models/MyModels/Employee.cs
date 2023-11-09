using System.ComponentModel.DataAnnotations.Schema;

namespace ModelFirst.Models.MyModels
{
    [Table("Employees")]
    public class Employee : User
    {
        public string Phone { get; set; }
    }
}
