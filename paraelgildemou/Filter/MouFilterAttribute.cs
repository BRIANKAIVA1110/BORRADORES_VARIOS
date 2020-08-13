using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace paraelgildemou.Filter
{
    public class MouFilterAttribute:ActionFilterAttribute
    {
        //este se ajecuta anter de entrar al acction o controller que tenga este filtro | attribute
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);


            //obtener sesion
            var session = filterContext.HttpContext.Session;
            
            //redireccion a controller y accion determinada, hay mas formas de redireccion
            //filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary
            //{
            //    { "controller","home" },
            //    { "action","contact" }
            //});
        }
    }
}