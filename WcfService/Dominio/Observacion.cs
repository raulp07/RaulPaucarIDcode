using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Observacion
    {

        [DataMember]
        public int cd_observacion { get; set; }
        [DataMember]
        public string cd_alumno { get; set; }
        [DataMember]
        public string ds_profesor { get; set; }
        [DataMember]
        public string ds_comentario { get; set; }
    }
}