using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    [Table("Student")]
    public class Student
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int StudentId{ get; set; }
        public string StudentName{ get; set; }
    }
}