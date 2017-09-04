using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2
{
    public class MyTablesController : Controller
    {
        private WebApplication2Context db = new WebApplication2Context();

        // GET: MyTables
        public ActionResult Index()
        {
            return View(db.MyTables.ToList());
        }

        // GET: MyTables/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.MyTables.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // GET: MyTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MyTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age")] MyTable myTable)
        {
            if (ModelState.IsValid)
            {
                db.MyTables.Add(myTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(myTable);
        }

        // GET: MyTables/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.MyTables.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // POST: MyTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age")] MyTable myTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(myTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(myTable);
        }

        // GET: MyTables/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MyTable myTable = db.MyTables.Find(id);
            if (myTable == null)
            {
                return HttpNotFound();
            }
            return View(myTable);
        }

        // POST: MyTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MyTable myTable = db.MyTables.Find(id);
            db.MyTables.Remove(myTable);
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
