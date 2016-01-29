using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using System.Data;
using System.Web.Services;

namespace WcfService
{
    
    [ServiceContract]
    public interface IReservaService
    {


        //[OperationContract]
        //List<Nota> ConsultarSituacionAcademicaXalumno(int cd_alumno);

        [OperationContract]
        Alumno ConsultarAlumno(int cd_alumno);

        [OperationContract]
        Padre ConsultarPadre(int cd_padre);

        [OperationContract]
        Alumno registarAlumno(int cd_padre,string ds_nombre,int cd_grado,string ds_apellido);

        //[OperationContract]
        //List<LibroPendiente> ConsultarLibrosPendientes(int cd_alumno);

        [OperationContract]
        List<Alumno> ListarAlumno(int id_padre);

        [OperationContract]
        List<Nota> ListarNotaAlumno(int cd_alumno);

        [OperationContract]
        List<LibroPendiente> ListarLibrosPrestados(int codigo);
        [OperationContract]
        List<Pago> ListarPagos(int cd_alumno);
        [OperationContract]
        ReservaMatricula registarReserva(int cd_alumno);
    }


}
