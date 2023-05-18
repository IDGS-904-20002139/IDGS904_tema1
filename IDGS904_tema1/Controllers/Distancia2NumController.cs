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
        public ActionResult DistanciaView(Distancia2Num distancia2Num)
        {
            if (distancia2Num.x1 == 0) 
            {
                return View(); 
            }
            else 
            {
                return RedirectToAction("Calcular", "Distancia2Num", distancia2Num);
            }
            
        }
        /*public ActionResult DistanciaView(Distancia2Num op)
        {
            var model = new Distancia2Num();
            model.Res = op.Dist();
            return View(model);
        }*/


        public ActionResult Calcular(Distancia2Num distancia2Num)
        {
            return Redirect("Resultado");
        }
        public ActionResult Resultado(Distancia2Num distancia2Num)
        {
            double resultado = distancia2Num.Dist();
            TempData["Resu"] = resultado.ToString();
            return View();
        }
    }
}