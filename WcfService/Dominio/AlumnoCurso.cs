using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class AlumnoCurso
    {
        [DataMember]
        public Alumno cd_alumno { get; set; }
        [DataMember]
        public Curso cd_curso { get; set; }
        [DataMember]
        public double qt_nota { get; set; }
        
    }
}