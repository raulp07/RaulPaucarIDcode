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
            return "Data Source=DESKTOP-74PRT41\\SQLEXPRESS;Initial Catalog=BD_IDCode;Integrated Security=true;";
        }
    }
}