using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoIDCode.CLASES
{
    public class LibroPendiente
    {
        public int cd_pendiente { get; set; }
        public string cd_alumno { get; set; }
        public int cd_libro { get; set; }
        public DateTime dt_fecha_prestamo { get; set; }
        public DateTime dt_fecha_devolucion { get; set; }
        public string ds_libro { get; set; }
        public string ds_autor { get; set; } 

    }
}