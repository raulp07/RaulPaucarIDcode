using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class ObligacionPago
    {
        [DataMember]
        public int  cd_grado { get; set; }
        [DataMember]
        public string ds_grado { get; set; }
        [DataMember]
        public decimal qt_monto { get; set; }
    }
}