using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dominio;

namespace WcfService.Persistencia
{
    public class BaseDAO<Entidad , Id>
    {
        public Entidad Crear(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Save(entidad);
                sesion.Flush();
            }
            return entidad;
        }
        public Entidad Obtener(Id id)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                return sesion.Get<Entidad>(id);
            }
        }
        public Entidad Modificar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Update(entidad);
                sesion.Flush();
            }
            return entidad;
        }
        public void Eliminar(Entidad entidad)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                sesion.Delete(entidad);
                sesion.Flush();
            }
        }
        public ICollection<Entidad> ListarTodos()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busqueda = sesion.CreateCriteria(typeof(Entidad));
                return busqueda.List<Entidad>();
            }
        }
         public ICollection<Entidad> ListarAlumno(int codigo)
        {

           /* Alumno alumno = new Alumno();
            alumno.cd_padre.cd_padre = codigo;*/

            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {

                ICriteria query = sesion.CreateCriteria(typeof(Alumno));
                query.Add(Restrictions.Eq("cd_padre.cd_padre", codigo));
                IList<Entidad> lista = query.List<Entidad>();
                return lista;
            }
        }

         public ICollection<Entidad> ListarNotasDesaprobadas(int codigo)
         {

             /* Alumno alumno = new Alumno();
              alumno.cd_padre.cd_padre = codigo;*/

             using (ISession sesion = NHibernateHelper.ObtenerSesion())
             {
                 int inicio = 0;
                 int fin = 10;
                 ICriteria query = sesion.CreateCriteria(typeof(Nota));
                 query.Add(Restrictions.Eq("cd_alumno.cd_alumno", codigo));
                 query.Add(Restrictions.Between("qt_nota",inicio,fin));
                 IList<Entidad> lista = query.List<Entidad>();
                 return lista;
             }
         }


         public ICollection<Entidad> ListarLibrosPrestados(int codigo)
         {

             /* Alumno alumno = new Alumno();
              alumno.cd_padre.cd_padre = codigo;*/

             using (ISession sesion = NHibernateHelper.ObtenerSesion())
             {                
                 ICriteria query = sesion.CreateCriteria(typeof(LibroPendiente));
                 query.Add(Restrictions.Eq("cd_alumno.cd_alumno", codigo));
                 IList<Entidad> lista = query.List<Entidad>();
                 return lista;
             }
         }
         public ICollection<Entidad> ListarPagos(int codigo)
         {

             /* Alumno alumno = new Alumno();
              alumno.cd_padre.cd_padre = codigo;*/

             using (ISession sesion = NHibernateHelper.ObtenerSesion())
             {
                 ICriteria query = sesion.CreateCriteria(typeof(Pago));
                 query.Add(Restrictions.Eq("cd_alumno.cd_alumno", codigo));
                 IList<Entidad> lista = query.List<Entidad>();
                 return lista;
             }
         }
    }
}