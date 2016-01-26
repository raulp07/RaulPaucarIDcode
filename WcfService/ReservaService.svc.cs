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

        private AlumnoCursoDAO alumnoCursoDAO = null;
        private AlumnoCursoDAO AlumnoCursoDAO
        {
            get
            {
                if(alumnoCursoDAO == null)
                    alumnoCursoDAO = new AlumnoCursoDAO();
                return alumnoCursoDAO;
            }
        }

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

        private ReservaMatriculaDAO reservaMatriculaDAO = null;
        private ReservaMatriculaDAO ReservaMatriculaDAO
        {
            get
            {
                if (reservaMatriculaDAO == null)
                    reservaMatriculaDAO = new ReservaMatriculaDAO();
                return reservaMatriculaDAO;
            }
        }

        public Alumno ConsultarAlumno(int cd_alumno)
        {
            return AlumnoDAO.Obtener(cd_alumno);
        }

        public AlumnoCurso ConsultarSituacionAcademica(int cd_alumno)
        {
            return AlumnoCursoDAO.Obtener(cd_alumno);
        }


        public Padre ConsultarPadre(int cd_padre)
        {
            return PadreDAO.Obtener(cd_padre);
        }


        public Alumno registarAlumno(int cd_padre, string ds_nombre, int cd_grado, string ds_apellido)
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

        public ReservaMatricula CrearReserva(int codigoAlumno, DateTime fechaReserva, char estado, double monto)
        {
            Alumno alumno = AlumnoDAO.Obtener(codigoAlumno);
            ReservaMatricula reserva = new ReservaMatricula()
            {
                Alumno = alumno,
                FechaReserva = fechaReserva,
                Estado = estado,
                Monto = monto
            };
            return ReservaMatriculaDAO.Crear(reserva);
        }

        public void CancelarReserva(int codigoReserva)
        {
            ReservaMatricula reserva = ReservaMatriculaDAO.Obtener(codigoReserva);
            ReservaMatriculaDAO.Eliminar(reserva);
        }
    }
}
