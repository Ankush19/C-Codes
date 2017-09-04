using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class PlayerInfoesController : Controller
    {
        private WebApplication3Context db = new WebApplication3Context();

        // GET: PlayerInfoes
        public ActionResult Index()
        {
            return View(db.PlayerInfoes.ToList());
        }

        // GET: PlayerInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerInfo playerInfo = db.PlayerInfoes.Find(id);
            if (playerInfo == null)
            {
                return HttpNotFound();
            }
            return View(playerInfo);
        }

        // GET: PlayerInfoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PlayerInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "JNo,PName,Goals")] PlayerInfo playerInfo)
        {
            if (ModelState.IsValid)
            {
                db.PlayerInfoes.Add(playerInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playerInfo);
        }

        // GET: PlayerInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerInfo playerInfo = db.PlayerInfoes.Find(id);
            if (playerInfo == null)
            {
                return HttpNotFound();
            }
            return View(playerInfo);
        }

        // POST: PlayerInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "JNo,PName,Goals")] PlayerInfo playerInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playerInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playerInfo);
        }

        // GET: PlayerInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PlayerInfo playerInfo = db.PlayerInfoes.Find(id);
            if (playerInfo == null)
            {
                return HttpNotFound();
            }
            return View(playerInfo);
        }

        // POST: PlayerInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PlayerInfo playerInfo = db.PlayerInfoes.Find(id);
            db.PlayerInfoes.Remove(playerInfo);
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
