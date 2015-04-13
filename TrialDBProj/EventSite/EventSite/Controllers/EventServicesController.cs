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
    public class EventServicesController : Controller
    {
        private EventDatabaseEntities1 db = new EventDatabaseEntities1();

        // GET: EventServices
        public ActionResult Index()
        {
            var eventServices = db.EventServices.Include(e => e.Event).Include(e => e.Service);
            return View(eventServices.ToList());
        }

        // GET: EventServices/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventService eventService = db.EventServices.Find(id);
            if (eventService == null)
            {
                return HttpNotFound();
            }
            return View(eventService);
        }

        // GET: EventServices/Create
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Description");
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Description");
            return View();
        }

        // POST: EventServices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventServiceId,EventId,ServiceId")] EventService eventService)
        {
            if (ModelState.IsValid)
            {
                db.EventServices.Add(eventService);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(db.Events, "EventId", "Description", eventService.EventId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Description", eventService.ServiceId);
            return View(eventService);
        }

        // GET: EventServices/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventService eventService = db.EventServices.Find(id);
            if (eventService == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Description", eventService.EventId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Description", eventService.ServiceId);
            return View(eventService);
        }

        // POST: EventServices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventServiceId,EventId,ServiceId")] EventService eventService)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventService).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.Events, "EventId", "Description", eventService.EventId);
            ViewBag.ServiceId = new SelectList(db.Services, "ServiceId", "Description", eventService.ServiceId);
            return View(eventService);
        }

        // GET: EventServices/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventService eventService = db.EventServices.Find(id);
            if (eventService == null)
            {
                return HttpNotFound();
            }
            return View(eventService);
        }

        // POST: EventServices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventService eventService = db.EventServices.Find(id);
            db.EventServices.Remove(eventService);
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
