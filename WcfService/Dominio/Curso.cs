using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Curso
    {
        [DataMember]
        public int cd_curso { get; set; }
        [DataMember]
        public string ds_curso { get; set; }
    }
}