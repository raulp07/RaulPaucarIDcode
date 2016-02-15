using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ProyectoIDCode.WSMatricula;


namespace ProyectoIDCode
{
    public partial class index : System.Web.UI.Page
    {

        WSMatricula.ReservaServiceClient alu = new WSMatricula.ReservaServiceClient();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargaralumnos();
            }
            
        }

        private void cargaralumnos()
        {
            //SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74PRT41\\SQLEXPRESS;Initial Catalog=BD_IDCode;Integrated Security=true;");
            //DataTable tb = new DataTable();
            //SqlCommand cmd = new SqlCommand("listar_alumnos", cn);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //da.Fill(tb);

            DataTable tb = new DataTable();
            tb.Columns.Add("cd_alumno");
            tb.Columns.Add("ds_nombre");
            tb.Columns.Add("ds_apellido");
            tb.Columns.Add("cd_grado");
            
            Array alumno =  alu.ListarAlumno("1");
            
            foreach (var item in alumno)
            {
                Alumno x = (Alumno) item;
                DataRow r = tb.NewRow();
                r["cd_alumno"] = x.cd_alumno;
                r["ds_nombre"] = x.ds_nombre;
                r["ds_apellido"] = x.ds_apellido;
                r["cd_grado"] = x.cd_grado;
                tb.Rows.Add(r);

            }
            lvalumnos.DataSource = tb;
            lvalumnos.DataBind();
        }


        public string traercodimg(string cod)
        {
            string cadena = "img/a" + cod +".jpg";
            return cadena;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lvalumnos_PagePropertiesChanged(object sender, EventArgs e)
        {
            //lvalumnos.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            
            //cargaralumnos();
        }

        protected void lvalumnos_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            string codigo = e.CommandArgument.ToString();
            Response.Redirect("form_wizard.aspx?cod_alumno=" + codigo);
        }

        protected void lvalumnos_DataBound(object sender, EventArgs e)
        {

        }
    }
}