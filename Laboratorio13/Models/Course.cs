using System.ComponentModel.DataAnnotations;

namespace Laboratorio13.Models
{
    public class Course
    {
     public int CourseId { get; set; }
     public string Name { get; set; }

     public int Credit { get; set; }

     public int activo { get; set; }
    }

   
}
