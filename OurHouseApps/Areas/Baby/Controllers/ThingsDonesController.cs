using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OurHouseApps;
using Microsoft.Ajax.Utilities;

namespace OurHouseApps.Areas.Baby.Controllers
{
    public class ThingsDonesController : Controller
    {
        private SDNAppsEntities db = new SDNAppsEntities();


        public JsonResult List(string term)
        {

            return Json(db.Actions.Where(m => m.Title.Contains(term)).Select(m => new { value = m.Title, m.index }).OrderBy(m => m.value).DistinctBy(m => m.value),
                    JsonRequestBehavior.AllowGet);
        }


        // GET: Baby/ThingsDones
        public ActionResult Index()
        {
            DateTime maxdate = DateTime.Now.Date.AddDays(-3);
            var thingsDones = db.ThingsDones.Include(t => t.BabyName).Include(t => t.LiquidSize).Where(td => td.StartTime > maxdate).OrderBy(m => m.StartTime);

            List<Models.ThingsDoneModelView> tdmv = new List<Models.ThingsDoneModelView>();

            foreach (ThingsDone item in thingsDones)
            {
                Models.ThingsDoneModelView tdmodelview = new Models.ThingsDoneModelView() { Action = item.Action1, ActionID = item.Action, Baby = item.BabyName,
                    BabyNameID = (int)item.BabyNameID,
                    EndTime = item.EndTime,
                    LiquidSizeID = item.LiquidSizeID,
                    Notes = item.Notes,
                    OZ = item.OZ,
                    StartTime = item.StartTime,
                    TotalTime = item.EndTime == null ? null : item.EndTime.Value.Subtract(item.StartTime).ToString(),
                    index = item.index
                };

                tdmv.Add(tdmodelview);
            }
            

            return View(tdmv);
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
            ViewBag.Actions = new SelectList(db.Actions, "index", "Title");

            Models.ThingsDoneModelCreate tdmc = new Models.ThingsDoneModelCreate();
            

            return View(tdmc);
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
