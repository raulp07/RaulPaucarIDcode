using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class LibroPendiente
    {
        [DataMember]
        public int cd_pendiente { get; set; }
        [DataMember]
        public Alumno cd_alumno { get; set; }
        [DataMember]
        public Libro cd_libro { get; set; }
        [DataMember]
        public DateTime dt_fecha_prestamo { get; set; }
        [DataMember]
        public DateTime dt_fecha_devolucion { get; set; }
    }
}