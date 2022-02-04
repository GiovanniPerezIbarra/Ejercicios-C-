using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MVCEFHM.Models;

namespace MVCEFHM.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            return View(llenar);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            return View(llenar.Find(id));
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            InstitutoTichEntities1 context = new InstitutoTichEntities1();
            List<Estados> estados = context.Estados.ToList();
            List<EstatusAlumnos> estatus = context.EstatusAlumnos.ToList();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre");
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre");
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos alumno)
        {
            try
            {
                // TODO: Add insert logic here
                InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
                DbSet<Alumnos> llenar = dbContext.Alumnos;
                llenar.Add(alumno);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
            DbSet<Alumnos> llenar = dbContext.Alumnos;
            Alumnos alumnos = llenar.Find(id);
            List<Estados> estados = dbContext.Estados.ToList();
            List<EstatusAlumnos> estatus = dbContext.EstatusAlumnos.ToList();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre", alumnos.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre", alumnos.idEstatus);
            return View(alumnos);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Alumnos alumno)
        {
            try
            {
                // TODO: Add update logic here
                InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
                DbSet<Alumnos> llenar = dbContext.Alumnos;
                dbContext.Entry(alumno).State = EntityState.Modified;
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            DbContext dbContext = new DbContext("InstitutoTichEntities1");
            DbSet<Alumnos> llenar = dbContext.Set<Alumnos>();
            return View(llenar.Find(id));
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Alumnos alumno)
        {
            try
            {
                // TODO: Add delete logic here
                InstitutoTichEntities1 dbContext = new InstitutoTichEntities1();
                DbSet<Alumnos> llenar = dbContext.Alumnos;
                Alumnos borrar = llenar.Find(id);
                llenar.Remove(borrar);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}