﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfService.Dominio
{
    [DataContract]
    public class Alumno
    {
        [DataMember]
        public int cd_alumno { get; set; }
        [DataMember]
        public Padre cd_padre { get; set; }
        [DataMember]
        public string ds_nombre { get; set; }
        [DataMember]
        public string ds_apellido { get; set; }
    }
}