using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;

namespace WcfService
{
    
    [ServiceContract]
    public interface IReservaService
    {
        [OperationContract]
        List<Nota> ConsultarSituacionAcademicaXalumno(int cd_alumno);

        [OperationContract]
        Alumno ConsultarAlumno(int cd_alumno);

        [OperationContract]
        Padre ConsultarPadre(int cd_padre);

        [OperationContract]
        Alumno registarAlumno(int cd_padre,string ds_nombre,int cd_grado,string ds_apellido);

        [OperationContract]
        List<LibroPendiente> ConsultarLibrosPendientes(int cd_alumno);



    }

}
