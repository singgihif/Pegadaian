﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebPegadaian.Models;

namespace WebPegadaian.Controllers
{
    public class InstallmentsController : Controller
    {
        private WebPegadaianEntities db = new WebPegadaianEntities();

        // GET: Installments
        public ActionResult Index()
        {
            var installments = db.Installments.Include(i => i.Transaction);
            return View(installments.ToList());
        }

        // GET: Installments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installment installment = db.Installments.Find(id);
            if (installment == null)
            {
                return HttpNotFound();
            }
            return View(installment);
        }

        // GET: Installments/Create
        public ActionResult Create()
        {
            ViewBag.Transaction_Id = new SelectList(db.Transactions, "Id", "Approved_Status");
            return View();
        }

        // POST: Installments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Installment_Date,Due_Date,Amount,Installment_Amount,Transaction_Id")] Installment installment)
        {
            if (ModelState.IsValid)
            {
                db.Installments.Add(installment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Transaction_Id = new SelectList(db.Transactions, "Id", "Approved_Status", installment.Transaction_Id);
            return View(installment);
        }

        // GET: Installments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installment installment = db.Installments.Find(id);
            if (installment == null)
            {
                return HttpNotFound();
            }
            ViewBag.Transaction_Id = new SelectList(db.Transactions, "Id", "Approved_Status", installment.Transaction_Id);
            return View(installment);
        }

        // POST: Installments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Installment_Date,Due_Date,Amount,Installment_Amount,Transaction_Id")] Installment installment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(installment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Transaction_Id = new SelectList(db.Transactions, "Id", "Approved_Status", installment.Transaction_Id);
            return View(installment);
        }

        // GET: Installments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Installment installment = db.Installments.Find(id);
            if (installment == null)
            {
                return HttpNotFound();
            }
            return View(installment);
        }

        // POST: Installments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Installment installment = db.Installments.Find(id);
            db.Installments.Remove(installment);
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
