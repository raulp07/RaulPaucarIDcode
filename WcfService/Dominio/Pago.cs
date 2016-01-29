using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Pago
    {
        [DataMember]
        public int cd_pago { get; set; }
        [DataMember]
        public string ds_pago { get; set; }

    }
}