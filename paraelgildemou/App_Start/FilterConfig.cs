using paraelgildemou.Filter;
using System.Web;
using System.Web.Mvc;

namespace paraelgildemou
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());// este ya estaba por defecto.



            /* este es para configurar de forma global, para no el atributo en todos los
             * controller sino que sea "automatico en todos
             * descomentar para que sea globar, en el global.asax se llama a esta clase y registra estos de forma global.
             * esta clase se llama desde el global.asax linea 16, donde hace la configuracion de forma global
             */
            //filters.Add(new MouFilterAttribute()); // este lo agregue yo obvi.
        }
    }
}
