using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AreaController : Controller
    {
        AreaModel area_m = new AreaModel();

        public ActionResult Index()
        {
            var areas = area_m.listarArea();
            ViewBag.areas = areas;
            return View();
        }

        public ActionResult Eliminar(int codigo)
        {
            area_m.EliminarArea(codigo);
            return RedirectToAction("index", "Area");
        }

        public ActionResult Editar(int codigo=0,string descripcion="",int tipo=0)
        {
            if (tipo==0)
            {
                area a = area_m.BuscarArea(codigo);
                ViewBag.area = a;
                return View();
            }
            else{
                area are = new area();
                are.are_cod = codigo;
                are.are_des = descripcion;

                area_m.ActualizarArea(are);
                return RedirectToAction("index", "Area");
            }
            
        }

    }
}