using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904_tema1.Models;

namespace IDGS904_tema1.Controllers
{
    public class TienditaController : Controller
    {
        // GET: Tiendita
        public ActionResult Index()
        {
            var alumno = new Alumnos()
            {
                nombre = "Pedro",
                edad = 20,
                activo = true,
                inscripto = new DateTime(2023, 1, 1)
            };
            ViewBag.alumno = alumno;
            return View();
        }
        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Grados(Grados gr)
        {
            var model = new Grados();
            model.result = gr.calcularGrados();
            return View(model);
        }
    }
}