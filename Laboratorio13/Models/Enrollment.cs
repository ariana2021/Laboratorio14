using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
namespace Laboratorio13.Models
{
 
        public class Enrollment
        {
            public int EnrollmentID { get; set; }
            public int StudentID { get; set; }
            public Student? Student { get; set; }
            public int CourseID { get; set; }
            public Course? Course { get; set; }
            public DateTime Date { get; set; }

        

    }
}