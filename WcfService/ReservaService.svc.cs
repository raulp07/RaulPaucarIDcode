using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using WcfService.Persistencia;

namespace WcfService
{
    public class ReservaService : IReservaService
    {

        private AlumnoDAO alumnoDAO = null;
        private AlumnoDAO AlumnoDAO
        {
            get
            {
                if (alumnoDAO == null)
                    alumnoDAO = new AlumnoDAO();
                return alumnoDAO;
            }
        }

        private NotaDAO notaDAO = null;
        private NotaDAO NotaDAO
        {
            get
            {
                if (notaDAO == null)
                    notaDAO = new NotaDAO();
                return notaDAO;
            }
        }

        private PadreDAO padreDAO = null;
        private PadreDAO PadreDAO
        {
            get
            {
                if (padreDAO == null)
                    padreDAO = new PadreDAO();
                return padreDAO;
            }
        }

        private ObligacionPagoDAO obligacionPagoDAO = null;
        private ObligacionPagoDAO ObligacionPagoDAO
        {
            get
            {
                if (obligacionPagoDAO == null)
                    obligacionPagoDAO = new ObligacionPagoDAO();
                return obligacionPagoDAO;
            }
        }

        private LibroPendienteDAO libroPendienteDAO = null;
        private LibroPendienteDAO LibroPendienteDAO
        {
            get
            {
                if (libroPendienteDAO == null)
                    libroPendienteDAO = new LibroPendienteDAO();
                return libroPendienteDAO;
            }
        }


        public Dominio.Alumno ConsultarAlumno(int cd_alumno)
        {
            return AlumnoDAO.Obtener(cd_alumno);
        }

        public Dominio.Padre ConsultarPadre(int cd_padre)
        {
            return PadreDAO.Obtener(cd_padre);
        }


        public Dominio.Alumno registarAlumno(int cd_padre, string ds_nombre, int cd_grado, string ds_apellido)
        {
            Padre padreExistente = PadreDAO.Obtener(cd_padre);
            ObligacionPago obligacionPago = ObligacionPagoDAO.Obtener(cd_grado);
            Alumno alumnoAregistrar = new Alumno()
            {
                cd_padre = padreExistente,
                ds_nombre = ds_nombre,
                ds_apellido = ds_apellido,
                cd_grado = obligacionPago
            };
            return AlumnoDAO.Crear(alumnoAregistrar);
        }

 
        public List<Nota> ConsultarSituacionAcademicaXalumno(int cd_alumno)
        {

            return NotaDAO.ListarSituacionAcademica(cd_alumno).ToList();
        }


        public List<LibroPendiente> ConsultarLibrosPendientes(int cd_alumno)
        {
            return LibroPendienteDAO.ListarSituacionAcademica(cd_alumno).ToList();
        }
    }
}
