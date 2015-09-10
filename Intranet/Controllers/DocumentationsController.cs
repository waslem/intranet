﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Intranet.DAL;
using Intranet.Models;

namespace Intranet.Controllers
{
    public class DocumentationsController : Controller
    {
        private DocumentationContext db = new DocumentationContext();

        // GET: Documentations
        public ActionResult Index()
        {

            return View(db.Documentations.ToList());
        }

        // GET: Documentations/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documentation documentation = db.Documentations.Find(id);
            
            if (documentation == null)
            {
                return HttpNotFound();
            }
            return View(documentation);
        }

        // GET: Documentations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Documentations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Description,Date,LastModified,CreatedBy")] Documentation documentation)
        {
            if (ModelState.IsValid)
            {
                db.Documentations.Add(documentation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(documentation);
        }

        // GET: Documentations/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documentation documentation = db.Documentations.Find(id);
            if (documentation == null)
            {
                return HttpNotFound();
            }
            return View(documentation);
        }

        // POST: Documentations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Description,Date,LastModified,CreatedBy")] Documentation documentation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(documentation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(documentation);
        }

        // GET: Documentations/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Documentation documentation = db.Documentations.Find(id);
            if (documentation == null)
            {
                return HttpNotFound();
            }
            return View(documentation);
        }

        // POST: Documentations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Documentation documentation = db.Documentations.Find(id);
            db.Documentations.Remove(documentation);
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
