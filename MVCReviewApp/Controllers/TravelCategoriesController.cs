using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCReviewApp.Models;

namespace MVCReviewApp.Controllers
{
    public class TravelCategoriesController : Controller
    {
        private MVCReviewAppContext db = new MVCReviewAppContext();

        // GET: TravelCategories
        public ActionResult Index()
        {
            return View(db.TravelCategories.ToList());
        }

        // GET: TravelCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelCategory travelCategory = db.TravelCategories.Find(id);
            if (travelCategory == null)
            {
                return HttpNotFound();
            }
            return View(travelCategory);
        }

        // GET: TravelCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TravelCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TravelCatID,Name")] TravelCategory travelCategory)
        {
            if (ModelState.IsValid)
            {
                db.TravelCategories.Add(travelCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(travelCategory);
        }

        // GET: TravelCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelCategory travelCategory = db.TravelCategories.Find(id);
            if (travelCategory == null)
            {
                return HttpNotFound();
            }
            return View(travelCategory);
        }

        // POST: TravelCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TravelCatID,Name")] TravelCategory travelCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(travelCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(travelCategory);
        }

        // GET: TravelCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TravelCategory travelCategory = db.TravelCategories.Find(id);
            if (travelCategory == null)
            {
                return HttpNotFound();
            }
            return View(travelCategory);
        }

        // POST: TravelCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TravelCategory travelCategory = db.TravelCategories.Find(id);
            db.TravelCategories.Remove(travelCategory);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
