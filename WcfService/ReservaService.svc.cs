using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WcfService.Dominio;
using WcfService.Persistencia;
using System.Data;

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

        private PagoDAO pagoDAO = null;
        private PagoDAO PagoDAO
        {
            get
            {
                if (pagoDAO == null)                
                    pagoDAO = new PagoDAO();
                    return pagoDAO;                
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

 
        public List<Alumno> ListarAlumno(int id_padre)
        {
            return AlumnoDAO.ListarAlumno(id_padre).ToList();
        }

        public List<Nota> ListarNotaAlumno(int cd_alumno)
        {
            return NotaDAO.ListarNotasDesaprobadas(cd_alumno).ToList();
        }
        public List<Pago> ListarPagos(int cd_alumno)
        {
            return PagoDAO.ListarPagos(cd_alumno).ToList();
        }
        public List<LibroPendiente> ListarLibrosPrestados(int codigo)
        {
            return LibroPendienteDAO.ListarLibrosPrestados(codigo).ToList();
        }




        public ReservaMatricula registarReserva(int cd_alumno)
        {
            Alumno alumno = AlumnoDAO.Obtener(cd_alumno);

            string estado = "Reserv";
            ReservaMatricula reserva = new ReservaMatricula()
            {
                Alumno = alumno,
                FechaReserva=DateTime.Now,
                Estado = 'R',
                Monto = double.Parse( alumno.cd_grado.qt_monto.ToString())

            };
            return ReservaMatriculaDAO.Crear(reserva);
        }

       




    }
}
