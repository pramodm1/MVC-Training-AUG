using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCProject.Controllers
{
    public class ViewmodelController : Controller
    {
        // GET: ViewmodelController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ViewmodelController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ViewmodelController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ViewmodelController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: ViewmodelController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ViewmodelController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: ViewmodelController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ViewmodelController/Delete/5
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
