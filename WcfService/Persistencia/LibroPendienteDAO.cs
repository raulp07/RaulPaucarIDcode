using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dominio;
using System.Data.SqlClient;
namespace WcfService.Persistencia
{
    public class LibroPendienteDAO:BaseDAO<LibroPendiente,int>
    {
        public List<LibroPendiente> ListarTodos(string codAlumno)
        {
            List<LibroPendiente> listaLibrosPendientes = new List<LibroPendiente>();
            //string sql = "SELECT * FROM tb_libro_pendiente WHERE cd_alumno=@cod";//"select tl.ds_titulo,tl.ds_autor , tlp.dt_fecha_prestamo,tlp.dt_fecha_devolucion from tb_libro tl inner join tb_libro_pendiente tlp on tl.cd_libro=tlp.cd_libro";
            string sql = "select tlp.cd_pendiente,tlp.cd_alumno,tlp.cd_libro,tlp.dt_fecha_prestamo,tlp.dt_fecha_devolucion, tl.ds_titulo,tl.ds_autor from tb_libro tl inner join tb_libro_pendiente tlp on tl.cd_libro=tlp.cd_libro WHERE tlp.cd_alumno = @cod";
            using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@cod", codAlumno));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        while (resultado.Read())
                        {
                            LibroPendiente libroPendiente = new LibroPendiente()
                            {
                                cd_pendiente = (int)resultado["cd_pendiente"],
                                cd_alumno = (string)resultado["cd_alumno"],
                                cd_libro = (int)resultado["cd_libro"],
                                dt_fecha_prestamo = (DateTime)resultado["dt_fecha_prestamo"],
                                dt_fecha_devolucion = (DateTime)resultado["dt_fecha_devolucion"],
                                ds_libro = (string)resultado["ds_titulo"],
                                ds_autor = (string)resultado["ds_autor"]

                            };
                            listaLibrosPendientes.Add(libroPendiente);
                        }
                    }
                }
            }
            return listaLibrosPendientes;
        }
    }
}