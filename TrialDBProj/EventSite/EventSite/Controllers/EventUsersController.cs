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
    public class EventUsersController : Controller
    {
        private EventDatabaseEntities1 db = new EventDatabaseEntities1();

        // GET: EventUsers
        public ActionResult Index()
        {
            return View(db.EventUsers.ToList());
        }

        // GET: EventUsers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventUser eventUser = db.EventUsers.Find(id);
            if (eventUser == null)
            {
                return HttpNotFound();
            }
            return View(eventUser);
        }

        // GET: EventUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventUserId,Fname,Lname,CompName,Phone,Email,Website,Address1,Address2,Town,County,NumServives,NumEvents,Biog,ImagePath")] EventUser eventUser)
        {
            if (ModelState.IsValid)
            {
                db.EventUsers.Add(eventUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventUser);
        }

        // GET: EventUsers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventUser eventUser = db.EventUsers.Find(id);
            if (eventUser == null)
            {
                return HttpNotFound();
            }
            return View(eventUser);
        }

        // POST: EventUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EventUserId,Fname,Lname,CompName,Phone,Email,Website,Address1,Address2,Town,County,NumServives,NumEvents,Biog,ImagePath")] EventUser eventUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventUser);
        }

        // GET: EventUsers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventUser eventUser = db.EventUsers.Find(id);
            if (eventUser == null)
            {
                return HttpNotFound();
            }
            return View(eventUser);
        }

        // POST: EventUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventUser eventUser = db.EventUsers.Find(id);
            db.EventUsers.Remove(eventUser);
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
