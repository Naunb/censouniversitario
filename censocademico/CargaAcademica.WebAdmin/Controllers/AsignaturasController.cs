using CargaAcademica.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CargaAcademica.WebAdmin.Controllers
{
    public class AsignaturasController : Controller
    {
        AsignaturasBL _asignaturasBL;
        PeriodoBL _periodoBL;

        public AsignaturasController()
        {
            _asignaturasBL = new AsignaturasBL();
            _periodoBL = new PeriodoBL();
        }

        // GET: Asignaturas
        public ActionResult Index()
        {
            var listadeAsignaturas = _asignaturasBL.ObtenerAsignaturas();
            //var periodo = _periodoBL.ObtenerPeriodo();

            ViewBag.PeriodoId =
               // new SelectList (periodo "Id", "Numero");

            return View(listadeAsignaturas);
        }

        public ActionResult Crear()
        {
            var nuevaAsignatura = new Asignatura();

            return View(nuevaAsignatura);
        }

        [HttpPost]
        public ActionResult Crear(Asignatura asignatura, HttpPostedFileBase imagen)
        {
            if (ModelState.IsValid)
            {
               // if (asignatura.PeriodoId == 0)
                {
                    ModelState.AddModelError("PeriodoId","Ingrese un periodo");
                    return View(asignatura);
                }
                if (imagen != null)
                {
//asignatura.UrlImagen = GuardarImagen(imagen);
                }
                _asignaturasBL.GuardarAsignatura(asignatura);

                return RedirectToAction("Index");
            }
            //var periodo = _periodoBL.ObtenerPeriodo();

            ViewBag.PeriodoId =
               // new SelectList(periodo, "Id", "año");

            return View(asignatura);
        }

        public ActionResult Editar(int id)
        {
            var asignatura = _asignaturasBL.ObtenerAsignatura(id);

            ViewBag.asignatura =
                new SelectList(asignatura, "Id", "seccion", perido.asignaturaId);

            return View(asignatura);
        }

        [HttpPost]
        public ActionResult Editar(Asignatura asignatura)
        {
            if (ModelState.IsValid)
            {
                if (asignatura.PeriodoId == 0)
                {
                    ModelState.AddModelError("PeriodoId", "Ingrese un periodo");
                    return View(asignatura);
                }

                _asignaturasBL.GuardarAsignatura(asignatura);

                return RedirectToAction("Index");
            }
            var periodo = _periodoBL.ObtenerPeriodo();

            ViewBag.PeriodoId =
                new SelectList(periodo, "Id", "año");

            return View(asignatura);
        }

            return View(asignatura);
        }

        public ActionResult Detalle(int id)
        {
            var asignatura = _asignaturasBL.ObtenerAsignatura(id);

            return View(asignatura);
        }

        public ActionResult Eliminar(int id)
        {
            var asignatura = _asignaturasBL.ObtenerAsignatura(id);

            return View(asignatura);
        }

        [HttpPost]
        public ActionResult Eliminar(Asignatura asignatura)
        {
            _asignaturasBL.EliminarAsignatura(asignatura.Id);

            return RedirectToAction("Index");
        }
    private string GuardaImagen(HttpPostedFileBase imagen)
    {
        string path = Server.MapPath("/Imagen/" + imagen.FileName);
            imagen.SaveAs(path);

        return "/Imagenes/" + imagen.FileName;
    }
    }
}