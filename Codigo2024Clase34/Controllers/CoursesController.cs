using Domain;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace Codigo2024Clase34.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        [HttpGet]
        public List<Course> Get()
        {
            var service = new CourseService();
            return service.Get();
        }
        [HttpPost]
        public void Insert(Course course )
        {
            var service = new CourseService();
            service.Insert(course);
        }
    }
}
