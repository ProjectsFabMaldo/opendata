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
    public class AgendaEventosController : Controller
    {
        private AgendaEventosDBContext db = new AgendaEventosDBContext();

        // GET: AgendaEventos
        public ActionResult Index()
        {
            return View(db.AgendaEventos.ToList());
        }

        // GET: AgendaEventos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaEventos agendaEventos = db.AgendaEventos.Find(id);
            if (agendaEventos == null)
            {
                return HttpNotFound();
            }
            return View(agendaEventos);
        }

        // GET: AgendaEventos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AgendaEventos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nombre,fecha,lugar")] AgendaEventos agendaEventos)
        {
            if (ModelState.IsValid)
            {
                db.AgendaEventos.Add(agendaEventos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(agendaEventos);
        }

        // GET: AgendaEventos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaEventos agendaEventos = db.AgendaEventos.Find(id);
            if (agendaEventos == null)
            {
                return HttpNotFound();
            }
            return View(agendaEventos);
        }

        // POST: AgendaEventos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nombre,fecha,lugar")] AgendaEventos agendaEventos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(agendaEventos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(agendaEventos);
        }

        // GET: AgendaEventos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AgendaEventos agendaEventos = db.AgendaEventos.Find(id);
            if (agendaEventos == null)
            {
                return HttpNotFound();
            }
            return View(agendaEventos);
        }

        // POST: AgendaEventos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AgendaEventos agendaEventos = db.AgendaEventos.Find(id);
            db.AgendaEventos.Remove(agendaEventos);
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
