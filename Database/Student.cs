using System.ComponentModel.DataAnnotations;

namespace Database
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
