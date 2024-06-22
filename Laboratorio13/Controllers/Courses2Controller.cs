using Laboratorio13.Models;
using Laboratorio13.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio13.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Courses2Controller : ControllerBase
    {
        private readonly SchoolContext _context;

        public Courses2Controller(SchoolContext context)
        {
            _context = context;
        }
        [HttpPost]
        public void Insert(InsertCourseRequest request)

        {
            //Request=>Model

            Course course = new Course();
            course.Name = request.Nombre;
            course.Credit = request.Credit;
            course.activo = 1;

            _context.Course.Add(course);
            _context.SaveChanges();

        }
    }
}
