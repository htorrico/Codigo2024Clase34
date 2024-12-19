using Domain;
using Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourseService
    {
        public List<Course> Get()
        {
            using (var contex = new DemoContext())
            {
                return contex.Courses.ToList();

            }
        }

        public void Insert(Course course)
        {
            {
                using (var contex = new DemoContext())
                {
                    contex.Courses.Add(course);
                    contex.SaveChanges();

                }
            }
        }
    }
}
