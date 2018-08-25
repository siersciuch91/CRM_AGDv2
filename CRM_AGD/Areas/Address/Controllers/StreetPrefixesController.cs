using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CRM_AGD;
using CRM_AGD.Areas.Address.Models;
using CRM_AGD.Context;

namespace CRM_AGD.Areas.Address.Controllers
{
    public class StreetPrefixesController : Controller
    {
        private AddressContext db = new AddressContext();

        // GET: Address/StreetPrefixes
        public ActionResult Index()
        {
            return View(db.StreetPrefixes.ToList());
        }

        // GET: Address/StreetPrefixes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreetPrefix streetPrefix = db.StreetPrefixes.Find(id);
            if (streetPrefix == null)
            {
                return HttpNotFound();
            }
            return View(streetPrefix);
        }

        // GET: Address/StreetPrefixes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Address/StreetPrefixes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StreetPrefixId,Prefix")] StreetPrefix streetPrefix)
        {
            if (ModelState.IsValid)
            {
                db.StreetPrefixes.Add(streetPrefix);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(streetPrefix);
        }

        // GET: Address/StreetPrefixes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreetPrefix streetPrefix = db.StreetPrefixes.Find(id);
            if (streetPrefix == null)
            {
                return HttpNotFound();
            }
            return View(streetPrefix);
        }

        // POST: Address/StreetPrefixes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StreetPrefixId,Prefix")] StreetPrefix streetPrefix)
        {
            if (ModelState.IsValid)
            {
                db.Entry(streetPrefix).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(streetPrefix);
        }

        // GET: Address/StreetPrefixes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StreetPrefix streetPrefix = db.StreetPrefixes.Find(id);
            if (streetPrefix == null)
            {
                return HttpNotFound();
            }
            return View(streetPrefix);
        }

        // POST: Address/StreetPrefixes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StreetPrefix streetPrefix = db.StreetPrefixes.Find(id);
            db.StreetPrefixes.Remove(streetPrefix);
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
