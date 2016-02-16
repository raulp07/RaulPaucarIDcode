using System;
using System.Runtime.Serialization;

namespace WcfService.Dominio
{
    [DataContract]
    public class ReservaMatricula
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public string cd_alumno { get; set; }
        [DataMember]
        public DateTime FechaReserva { get; set; }
        [DataMember]
        public char fg_estado { get; set; }
        [DataMember]
        public double Monto { get; set; }
    }
}