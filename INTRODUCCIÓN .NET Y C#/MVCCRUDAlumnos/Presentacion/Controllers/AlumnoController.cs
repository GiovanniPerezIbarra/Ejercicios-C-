using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Negocio.ServiceReference1;

namespace Presentacion.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        public ActionResult Index()
        {
            NAlumno nAlumno = new NAlumno();
            List<Alumnos> alumnos = nAlumno.Consultar();
            return View(alumnos);
        }

        // GET: Alumno/Details/5
        public ActionResult Details(int id)
        {
            NAlumno con = new NAlumno();
            Alumnos modelo = con.Consultar(id);
            return View(modelo);
        }
        public ActionResult AportacionesIMSS(int id)
        {
            NAlumno con = new NAlumno();
            AportacionesIMSS modelo = con.CalcularIMMS(id);
            return PartialView(modelo);
        }
        public ActionResult _TablaISR(int id)
        {
            NAlumno con = new NAlumno();
            TablaISR modelo = con.CalcularISR(id);
            return PartialView(modelo);
        }

        // GET: Alumno/Create
        public ActionResult Create()
        {
            NEstado est = new NEstado();
            NEstatusAlumno estt = new NEstatusAlumno();
            List<Estados> estados = est.Consultar();
            List<EstatusAlumnos> estatus = estt.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre");
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre");
            return View();
        }

        // POST: Alumno/Create
        [HttpPost]
        public ActionResult Create(Alumnos nuevo)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    NAlumno con = new NAlumno();
                    con.Agregar(nuevo);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                
            }
            NEstado est = new NEstado();
            NEstatusAlumno estt = new NEstatusAlumno();
            List<Estados> estados = est.Consultar();
            List<EstatusAlumnos> estatus = estt.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre");
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre");
            return View(nuevo);
        }

        // GET: Alumno/Edit/5
        public ActionResult Edit(int id)
        {
            NAlumno alum = new NAlumno();
            NEstado est = new NEstado();
            NEstatusAlumno estt = new NEstatusAlumno();
            Alumnos find = alum.Consultar(id);
            List<Estados> estados = est.Consultar();
            List<EstatusAlumnos> estatus = estt.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre", find.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre", find.idEstatus);

            NAlumno modelo = new NAlumno();
            Alumnos alu = modelo.Consultar(id);
            return View(alu);
        }

        // POST: Alumno/Edit/5
        [HttpPost]
        public ActionResult Edit(Alumnos editado)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    NAlumno con = new NAlumno();
                    con.Actualizar(editado);
                    return RedirectToAction("Index");
                }
            }
            catch
            {
                
            }
            NEstado est = new NEstado();
            NEstatusAlumno estt = new NEstatusAlumno();
            List<Estados> estados = est.Consultar();
            List<EstatusAlumnos> estatus = estt.Consultar();
            ViewBag.idEstadoOrigen = new SelectList(estados, "idEstados", "nombre", editado.idEstadoOrigen);
            ViewBag.idEstatus = new SelectList(estatus, "idEstatusAlumnos", "nombre", editado.idEstatus);
            return View(editado);
        }

        // GET: Alumno/Delete/5
        public ActionResult Delete(int id)
        {
            NAlumno con = new NAlumno();
            Alumnos modelo = con.Consultar(id);
            return View(modelo);
        }

        // POST: Alumno/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                NAlumno con = new NAlumno();
                con.Eliminar(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}