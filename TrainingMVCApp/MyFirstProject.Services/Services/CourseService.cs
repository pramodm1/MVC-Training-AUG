using MyFirstProject.Services.ViewModel;
using MyMVCProject.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject.Services.Services
{
    public interface ICourseService
    {
        public List<vwCourse> GetCourses();
        public int CreateCourse(Course course);
    }
    public class CourseService : ICourseService
    {
        public CourseService(StudentDbContext context)
        {
            _context = context;
        }
        private readonly StudentDbContext _context;
        public List<vwCourse> GetCourses()
        {
            List<vwCourse> courses = new List<vwCourse>();
            courses = _context.Course.Select(s => new vwCourse()
            {
                Description = s.Description,
                ID = s.ID,
                Name = s.Name,
            }).ToList();

            return courses;
        }
        public int CreateCourse(Course course)
        {
            try
            {
                _context.Course.Add(course);
                _context.SaveChanges();
                return course.ID;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
