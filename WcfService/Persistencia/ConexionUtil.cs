using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Persistencia
{
    public class ConexionUtil
    {
        public static string ObtenerCadena()
        {
            return "Data Source=(local);Initial Catalog=BD_ProyectoDSD2;Integrated Security=SSPI;";
        }
    }
}