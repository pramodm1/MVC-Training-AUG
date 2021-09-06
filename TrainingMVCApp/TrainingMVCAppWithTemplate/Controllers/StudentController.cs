using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TrainingMVCAppWithTemplate.Models;

namespace TrainingMVCAppWithTemplate.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        private readonly IStudentRepository _repository = null;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public ActionResult Index()
        {
            //StudentRepository studentRepository = new StudentRepository();
            var result = _repository.getAllStudent();
            return View(result);
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            //StudentRepository studentRepository = new StudentRepository();
            var result = _repository.getStudentById(id);
            return View(result);
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                // StudentRepository studentRepository = new StudentRepository();
                _repository.CreateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
           var result= _repository.getStudentById(id);
            return View(result);
        }

        // POST: StudentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Student student)
        {
            try
            {
                _repository.UpdateStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
