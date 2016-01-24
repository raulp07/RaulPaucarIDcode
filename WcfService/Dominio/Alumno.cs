using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Dominio
{
    public class Alumno
    {
        public int cd_alumno { get; set; }
        public int cd_padre { get; set; }
        public string ds_nombre { get; set; }
        public string ds_apellido { get; set; }
        public int cd_grado { get; set; }
    }
}