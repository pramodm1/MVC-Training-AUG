using Microsoft.AspNetCore.Mvc;
using MyFirstProject.Services.Services;
using MyFirstProject.Services.ViewModel;
using MyMVCProject.DAL.Data;
using System;
using System.Collections.Generic;

namespace MyMVCProject.Controllers
{
    public class CourseController : Controller
    {
        private readonly StudentDbContext _context;
        private readonly ICourseService _courseService;

        public CourseController(StudentDbContext context, ICourseService courseService)
        {
            _context = context;
            _courseService = courseService;
        }

        // GET: Course/List
        public IActionResult Index()
        {
            List<vwCourse> courses = _courseService.GetCourses();
            return View(courses);
        }
        // GET: Course/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        // POST: Course/Create
        [HttpPost]
        public IActionResult Create(Course course)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            else
            {
                course.IsActive = true;
                course.CreatedAt = DateTime.UtcNow;
                course.UpdatedAt = DateTime.UtcNow;
                course.CreatedBy = 1;
                course.UpdatedBy = 1;
                var loggedInUser = User;
            }
            _courseService.CreateCourse(course);
            return View(course);
        }
    }
}
