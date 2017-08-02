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
    public class ThingsDonesController : Controller
    {
        private SDNAppsEntities db = new SDNAppsEntities();

        // GET: Baby/ThingsDones
        public ActionResult Index()
        {
            var thingsDones = db.ThingsDones.Include(t => t.BabyName).Include(t => t.LiquidSize);
            return View(thingsDones.ToList());
        }

        // GET: Baby/ThingsDones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThingsDone thingsDone = db.ThingsDones.Find(id);
            if (thingsDone == null)
            {
                return HttpNotFound();
            }
            return View(thingsDone);
        }

        // GET: Baby/ThingsDones/Create
        public ActionResult Create()
        {
            ViewBag.BabyNameID = new SelectList(db.BabyNames, "ID", "BabyName1");
            ViewBag.LiquidSizeID = new SelectList(db.LiquidSizes, "Id", "Type");
            return View();
        }

        // POST: Baby/ThingsDones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "index,Action,StartTime,EndTime,Delete,OZ,Mood,Notes,IPAddress,Longitude,Latitude,LiquidSizeID,BabyNameID")] ThingsDone thingsDone)
        {
            if (ModelState.IsValid)
            {
                db.ThingsDones.Add(thingsDone);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BabyNameID = new SelectList(db.BabyNames, "ID", "BabyName1", thingsDone.BabyNameID);
            ViewBag.LiquidSizeID = new SelectList(db.LiquidSizes, "Id", "Type", thingsDone.LiquidSizeID);
            return View(thingsDone);
        }

        // GET: Baby/ThingsDones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThingsDone thingsDone = db.ThingsDones.Find(id);
            if (thingsDone == null)
            {
                return HttpNotFound();
            }
            ViewBag.BabyNameID = new SelectList(db.BabyNames, "ID", "BabyName1", thingsDone.BabyNameID);
            ViewBag.LiquidSizeID = new SelectList(db.LiquidSizes, "Id", "Type", thingsDone.LiquidSizeID);
            return View(thingsDone);
        }

        // POST: Baby/ThingsDones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "index,Action,StartTime,EndTime,Delete,OZ,Mood,Notes,IPAddress,Longitude,Latitude,LiquidSizeID,BabyNameID")] ThingsDone thingsDone)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thingsDone).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BabyNameID = new SelectList(db.BabyNames, "ID", "BabyName1", thingsDone.BabyNameID);
            ViewBag.LiquidSizeID = new SelectList(db.LiquidSizes, "Id", "Type", thingsDone.LiquidSizeID);
            return View(thingsDone);
        }

        // GET: Baby/ThingsDones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ThingsDone thingsDone = db.ThingsDones.Find(id);
            if (thingsDone == null)
            {
                return HttpNotFound();
            }
            return View(thingsDone);
        }

        // POST: Baby/ThingsDones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ThingsDone thingsDone = db.ThingsDones.Find(id);
            db.ThingsDones.Remove(thingsDone);
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
