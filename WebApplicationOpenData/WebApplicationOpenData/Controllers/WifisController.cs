using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplicationOpenData.Models;

namespace WebApplicationOpenData.Controllers
{
    public class WifisController : Controller
    {
        private WifiDBContext db = new WifiDBContext();

        // GET: Wifis
        public ActionResult Index()
        {
            return View(db.AgendaEventos.ToList());
        }

        // GET: Wifis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wifi wifi = db.AgendaEventos.Find(id);
            if (wifi == null)
            {
                return HttpNotFound();
            }
            return View(wifi);
        }

        // GET: Wifis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Wifis/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,centro,descripcion")] Wifi wifi)
        {
            if (ModelState.IsValid)
            {
                db.AgendaEventos.Add(wifi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wifi);
        }

        // GET: Wifis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wifi wifi = db.AgendaEventos.Find(id);
            if (wifi == null)
            {
                return HttpNotFound();
            }
            return View(wifi);
        }

        // POST: Wifis/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,centro,descripcion")] Wifi wifi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wifi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wifi);
        }

        // GET: Wifis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Wifi wifi = db.AgendaEventos.Find(id);
            if (wifi == null)
            {
                return HttpNotFound();
            }
            return View(wifi);
        }

        // POST: Wifis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Wifi wifi = db.AgendaEventos.Find(id);
            db.AgendaEventos.Remove(wifi);
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
