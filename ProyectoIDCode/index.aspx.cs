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
                SqlConnection cn = new SqlConnection("Data Source=DESKTOP-74PRT41\\SQLEXPRESS;Initial Catalog=BD_IDCode;Integrated Security=true;");
                DataTable tb=new DataTable();
                SqlCommand cmd = new SqlCommand("listar_alumnos",cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tb);
                GridView1.DataSource = tb;
                GridView1.DataBind();
            }
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}