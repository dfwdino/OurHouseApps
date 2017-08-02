using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OurHouseApps;

namespace OurHouseApps.Areas.Baby.Controllers
{
    public class ActionCategoriesController : Controller
    {
        private SDNAppsEntities db = new SDNAppsEntities();

        // GET: Baby/ActionCategories
        public ActionResult Index()
        {
            return View(db.ActionCategories.ToList());
        }

        // GET: Baby/ActionCategories/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionCategory actionCategory = db.ActionCategories.Find(id);
            if (actionCategory == null)
            {
                return HttpNotFound();
            }
            return View(actionCategory);
        }

        // GET: Baby/ActionCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Baby/ActionCategories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Index,Category,Delete,IPAddress,Longitude,Latitude")] ActionCategory actionCategory)
        {
            if (ModelState.IsValid)
            {
                actionCategory.Index = Guid.NewGuid();
                db.ActionCategories.Add(actionCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(actionCategory);
        }

        // GET: Baby/ActionCategories/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionCategory actionCategory = db.ActionCategories.Find(id);
            if (actionCategory == null)
            {
                return HttpNotFound();
            }
            return View(actionCategory);
        }

        // POST: Baby/ActionCategories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Index,Category,Delete,IPAddress,Longitude,Latitude")] ActionCategory actionCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(actionCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(actionCategory);
        }

        // GET: Baby/ActionCategories/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ActionCategory actionCategory = db.ActionCategories.Find(id);
            if (actionCategory == null)
            {
                return HttpNotFound();
            }
            return View(actionCategory);
        }

        // POST: Baby/ActionCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            ActionCategory actionCategory = db.ActionCategories.Find(id);
            actionCategory.Delete = true;
            //db.ActionCategories.Remove(actionCategory);
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
