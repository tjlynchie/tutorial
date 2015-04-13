using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventSite.Models;

namespace EventSite.Controllers
{
    public class EventsController : Controller
    {
        private EventDatabaseEntities1 db = new EventDatabaseEntities1();

        // GET: Events
        public ActionResult Index()
        {
            var events = db.Events.Include(e => e.EventUser);
            return View(events.ToList());
        }

        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event ev = db.Events.Find(id);
            if (ev == null)
            {
                return HttpNotFound();
            }
            return View(ev);
        }

        // GET: Events/Create
        public ActionResult Create()
        {
            ViewBag.EventUserId = new SelectList(db.EventUsers, "EventUserId", "Fname");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,EventUserId,Description,Category,StartTime,EndTime,StartDate,EndDate,Attendance")] Event ev)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(ev);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventUserId = new SelectList(db.EventUsers, "EventUserId", "Fname", ev.EventUserId);
            return View(ev);
        }

        // GET: Events/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event ev = db.Events.Find(id);
            if (ev == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventUserId = new SelectList(db.EventUsers, "EventUserId", "Fname", ev.EventUserId);
            return View(ev);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventId,EventUserId,Description,Category,StartTime,EndTime,StartDate,EndDate,Attendance")] Event ev)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ev).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventUserId = new SelectList(db.EventUsers, "EventUserId", "Fname", ev.EventUserId);
            return View(ev);
        }

        // GET: Events/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event ev = db.Events.Find(id);
            if (ev == null)
            {
                return HttpNotFound();
            }
            return View(ev);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event ev = db.Events.Find(id);
            db.Events.Remove(ev);
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
