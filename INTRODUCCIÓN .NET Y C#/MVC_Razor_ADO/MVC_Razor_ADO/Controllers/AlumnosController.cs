using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidades;
using Negocio;

namespace MVC_Razor_ADO.Controllers
{
    public class AlumnosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            NAlumno con = new NAlumno();
            List<Alumno> hola = con.Consultar();
            return View(hola);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            NAlumno con = new NAlumno();
            Alumno modelo = con.Consultar(id);
            return View(modelo);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            NAlumno con = new NAlumno();
            Alumno modelo = con.Consultar(id);
            return View(modelo);
        }
        [HttpPost]
        public ActionResult Delete(Alumno alumno)
        {
            NAlumno con = new NAlumno();
            con.Eliminar(alumno.idAlumnos);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Alumno nuevo)
        {
            NAlumno con = new NAlumno();
            con.Agregar(nuevo);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            NAlumno con = new NAlumno();
            Alumno consultar = con.Consultar(id);
            return View(consultar);
        }
        [HttpPost]
        public ActionResult Edit(Alumno editado)
        {
            NAlumno con = new NAlumno();
            con.Actualizar(editado);
            return RedirectToAction("Index");
        }
    }
}