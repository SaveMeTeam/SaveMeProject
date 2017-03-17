using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SaveMeProject.Models;

namespace SaveMeProject.Controllers
{
    public class ReportAbusersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ReportAbusers
     
        public ActionResult Index()
        {
            return View(db.ReportAbusers.ToList());
        }

        [Authorize]

        // GET: ReportAbusers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAbuser reportAbuser = db.ReportAbusers.Find(id);
            if (reportAbuser == null)
            {
                return HttpNotFound();
            }
            return View(reportAbuser);
        }

        // GET: ReportAbusers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReportAbusers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ReportID,Topic,Date,Food,Shelter,Abandoned,Poisoned,Underweight,Trapping,Water,Shot,Injury,Abuse,Other,AbuseDetails,PropertyDescription,AbuserDescription,OwnerName,FullName,ReportEmail,ReportPhone,Contact,Updates,Latitude,Longitude")] ReportAbuser reportAbuser)
        {
            if (ModelState.IsValid)
            {
                db.ReportAbusers.Add(reportAbuser);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(reportAbuser);
        }
        [Authorize]
        // GET: ReportAbusers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAbuser reportAbuser = db.ReportAbusers.Find(id);
            if (reportAbuser == null)
            {
                return HttpNotFound();
            }
            return View(reportAbuser);
        }

        // POST: ReportAbusers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ReportID,Topic,Date,Food,Shelter,Abandoned,Poisoned,Underweight,Trapping,Water,Shot,Injury,Abuse,Other,AbuseDetails,PropertyDescription,AbuserDescription,OwnerName,FullName,ReportEmail,ReportPhone,Contact,Updates,Latitude,Longitude")] ReportAbuser reportAbuser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(reportAbuser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(reportAbuser);
        }
        [Authorize]
        // GET: ReportAbusers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ReportAbuser reportAbuser = db.ReportAbusers.Find(id);
            if (reportAbuser == null)
            {
                return HttpNotFound();
            }
            return View(reportAbuser);
        }

        // POST: ReportAbusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ReportAbuser reportAbuser = db.ReportAbusers.Find(id);
            db.ReportAbusers.Remove(reportAbuser);
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
