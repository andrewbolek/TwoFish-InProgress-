using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TwoFish.WebUI.Models;

namespace TwoFish.WebUI.Controllers
{
    public class FishController : Controller
    {
        private EncloypediaEntities db = new EncloypediaEntities();

        // GET: Fish
        public ActionResult Index()
        {
            //var fish = db.Fish.Include(f => f.FishOfTheDay);
            //return View(fish.ToList());
            return View();
        }
        public ActionResult FishList()
        {
            var fish = db.Fish.Include(f => f.FishOfTheDay);
            return View(fish.ToList());
        }
        // GET: Fish/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fish fish = db.Fish.Find(id);
            if (fish == null)
            {
                return HttpNotFound();
            }
            return View(fish);
        }

        // GET: Fish/Create
        public ActionResult Create()
        {
            ViewBag.FishID = new SelectList(db.FishOfTheDays, "FishID", "Type");
            return View();
        }

        // POST: Fish/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FishID,Type,Weight,History,Picture,HabitatID")] Fish fish)
        {
            if (ModelState.IsValid)
            {
                db.Fish.Add(fish);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FishID = new SelectList(db.FishOfTheDays, "FishID", "Type", fish.FishID);
            return View(fish);
        }

        // GET: Fish/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fish fish = db.Fish.Find(id);
            if (fish == null)
            {
                return HttpNotFound();
            }
            ViewBag.FishID = new SelectList(db.FishOfTheDays, "FishID", "Type", fish.FishID);
            return View(fish);
        }

        // POST: Fish/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FishID,Type,Weight,History,Picture,HabitatID")] Fish fish)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fish).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FishID = new SelectList(db.FishOfTheDays, "FishID", "Type", fish.FishID);
            return View(fish);
        }

        // GET: Fish/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Fish fish = db.Fish.Find(id);
            if (fish == null)
            {
                return HttpNotFound();
            }
            return View(fish);
        }

        // POST: Fish/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Fish fish = db.Fish.Find(id);
            db.Fish.Remove(fish);
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
        public ActionResult NotFound()
        {
            
            return View();
        }
        public ActionResult History()
        {

            return View();
        }
    }
}
