using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mundri_task.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [DisplayName("Employee Name")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Department Name")]
        public string Department { get; set; }
        [Required]
        [DisplayName("Employee Salary")]
        public int Salary { get; set; }
    }
}
