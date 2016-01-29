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
        public Alumno Alumno { get; set; }
        [DataMember]
        public DateTime FechaReserva { get; set; }
        [DataMember]
        public char Estado { get; set; }
        [DataMember]
        public double Monto { get; set; }
    }
}