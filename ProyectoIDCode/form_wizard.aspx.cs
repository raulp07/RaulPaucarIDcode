using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProyectoIDCode
{
    public partial class form_wizard : System.Web.UI.Page
    {

        static string cod_alumno;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cod_alumno = Request.QueryString["cod_alumno"];
            }
        }
    }
}