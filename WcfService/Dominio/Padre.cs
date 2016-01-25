using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Padre
    {
        [DataMember]
        public int cd_padre { get; set; }
        [DataMember]
        public string ds_nombre { get; set; }
        [DataMember]
        public string ds_apellido { get; set; }
    }
}