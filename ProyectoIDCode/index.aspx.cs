using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoIDCode
{
    public partial class index : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargaralumnos();
            }
            
        }

        private void cargaralumnos()
        {
            SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74PRT41\\SQLEXPRESS;Initial Catalog=BD_IDCode;Integrated Security=true;");
            DataTable tb = new DataTable();
            SqlCommand cmd = new SqlCommand("listar_alumnos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tb);
            lvalumnos.DataSource = tb;
            lvalumnos.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void lvalumnos_PagePropertiesChanged(object sender, EventArgs e)
        {
            lvalumnos.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            cargaralumnos();
        }

        protected void lvalumnos_ItemCommand(object sender, ListViewCommandEventArgs e)
        {

        }

        protected void lvalumnos_DataBound(object sender, EventArgs e)
        {

        }
    }
}