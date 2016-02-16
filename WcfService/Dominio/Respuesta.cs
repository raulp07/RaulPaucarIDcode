using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace WcfService.Dominio
{
    [DataContract]
    public class Respuesta
    {
        [DataMember]
        public string mensaje { get; set; }
        [DataMember]
        public int flag { get; set; }
    }
}