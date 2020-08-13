using paraelgildemou.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paraelgildemou.Controllers
{
    /// <summary>
    /// fijate que el filtro que cree solo esta en about, el atributo || filtro que cree
    /// te redirecciona a contactos
    /// 
    /// actuamente esta configurado para que se determine el action o contrller que usara el filtro
    /// fijate que tiene [MouFilter] en el action.
    /// 
    /// para no estar poniendo el atributo [MouFilter] en cada controller o acction se puede hacer una configuracion 
    /// global, este se hace en:
    /// 
    /// App_Start -> FilterConfig.cs  -> ya lo agregue a linea de codigo pero esta comentado,
    /// si queres probarlo de forma global, descomentalo y en este archivo comenta el atributo
    /// [MouFilter] que esta en el action about. hacerlo de forma global hara que se ajecute por cada accion que se
    /// ejecute en la app.
    /// 
    /// 
    /// 
    /// nota: pone breakpoint en la linea 13 del archivo MouFilterAttribute.cs que esta en el directorio "Filter".
    /// asi debbugueas y ves que entra al metodo "OnActionExecuting" antes de ejecutar el metodo action "about".
    /// 
    /// 
    /// pdt: si no entendiste esto tus papa son primos hdp. sino depues lo vemos qliao
    /// 
    /// </summary>
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //filtro personalizado, si vas a probar la forma global comenta este atributo ya que va a ser al pedo
        //que este puesto ya que si esta de forma global entra en todos sin que este este puesto([MouFilter]).
        [MouFilter]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}