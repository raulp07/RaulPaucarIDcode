using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Libro
    {
        [DataMember]
        public int cd_libro { get; set; }
        [DataMember]
        public string ds_titulo { get; set; }
        [DataMember]
        public string  ds_autor { get; set; }
    }
}