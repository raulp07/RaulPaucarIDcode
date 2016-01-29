using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Nota
    {
        [DataMember]
        public int cd_nota { get; set; }

        [DataMember]
        public Alumno cd_alumno { get; set; }

        [DataMember]
        public string desc_curso { get; set; }

        [DataMember]
        public int qt_nota { get; set; }

    }
}