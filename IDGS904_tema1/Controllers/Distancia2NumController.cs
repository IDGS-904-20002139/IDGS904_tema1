using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IDGS904_tema1.Models;

namespace IDGS904_tema1.Controllers
{
    public class Distancia2NumController : Controller
    {
        // GET: Distancia2Num
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DistanciaView(Distancia2Num op)
        {
            var model = new Distancia2Num();
            model.Res = op.Dist();
            TempData["Resu"] = model.Res;
            return View(model);
        }
        /*public ActionResult Resultado()
        {
            string resul = "";
            if (TempData.ContainsKey("Resu"))
            {
                resul = TempData["Resu"] as string;
            }
            ViewBag.resultado = resul;

            return View();
        }*/
    }
}