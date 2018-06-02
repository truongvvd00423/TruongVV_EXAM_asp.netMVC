using MVC.NET_Subject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.NET_Subject.Controllers
{
    public class SubjectController : Controller
    {
        private SubjectDBContext db = new SubjectDBContext();
        // GET: Subject
        public ActionResult Index()
        {
            var TypeLst = new List<string>();
            var TypeQuery = from d in db.Subjects
                            orderby d.Subject1
                            select d.Subject1;
            TypeLst.AddRange(TypeQuery.Distinct());
            var subjects = from p in db.Subjects
                           orderby p.Subject1
                           select p;

            return View(subjects);
        }

        // GET: Subject/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Subject/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Subject/Create
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,StartTime,Duration,ExamDate,ClassRoom,Faculty,Status")] Subject subject)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Subjects.Add(subject);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(subject);
            }
            catch
            {
                return View();
            }
        }

        // GET: Subject/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subject/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subject/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subject/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
