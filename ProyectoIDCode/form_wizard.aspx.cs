using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoIDCode.WSMatricula;
namespace ProyectoIDCode
{
    public partial class form_wizard : System.Web.UI.Page
    {
        
       
        static int cod_alumno;
        static int notas=0, bibli=0, deud=0;

        WSMatricula.ReservaServiceClient ws = new WSMatricula.ReservaServiceClient();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cod_alumno =  Int32.Parse(Request.QueryString["cod_alumno"].ToString());
                cargarmensaje(sender,e);
            }
        }

        public void cargarmensaje(object sender, EventArgs e)
        {

            btndevolucion.Enabled = false;
            btnestadoD.Enabled = false;
            //btnfinish.Enabled = false;
            btnsitacademica_Click(sender, e);
        }



        protected void btnfinish_Click(object sender, EventArgs e)
        {

            pnl_mensajeFinal.Visible = true;
            ReservaMatricula res = ws.registarReserva(cod_alumno);

            //lblmensaje.Text = "Codigo unico de matricula:" + res.Codigo + "\n" +
            //   "Nombre de Alumno:" + res.Alumno.ds_apellido + " " + res.Alumno.ds_nombre + "\n" +
            //    "Pago a realizar:" + res.Monto + " Soles" + "\n" +
            //   "Fecha de reserva: " + res.FechaReserva + "\n";
            lblmsj1.Text = res.Codigo.ToString();
            lblmsj2.Text = res.Alumno.ds_nombre.ToString();
            lblmsj3.Text = res.Monto.ToString();
            lblmsj4.Text = res.FechaReserva.ToString();
            //Codigo unico de matricula: XXX
            //Nombre de Alumno: XXX
            //Pago a realizar:
            //Fecha de reserva: 

            

        }

        protected void btcontinuar_Click(object sender, EventArgs e)
        {

            if (btndevolucion.Enabled.ToString().Equals("False"))
            {
                btndevolucion.Enabled = true;
                btndevolucion_Click(sender, e);
            }else if (btnestadoD.Enabled.ToString().Equals("False"))
            {
                btnestadoD.Enabled = true;
                btnestadoD_Click(sender, e);
            }
            

        }

        protected void btnsitacademica_Click(object sender, EventArgs e)
        {
            if (ws.ListarNotaAlumno(cod_alumno).Count() > 0)
            {
                notas = 0;
                lblmensaje.Text = "Usted no cumple con el requisito de Notas aprobadas. Por favor, acérquese al área de secretaria.";
            }
            else
            {
                notas = 1;
                lblmensaje.Text = "El Alumno no debe ninguna materia académica.";
            }
            validar_fini();
        }

        protected void btndevolucion_Click(object sender, EventArgs e)
        {
            if (ws.ListarLibrosPrestados(cod_alumno).Count() > 0)
            {
                bibli = 0;
                lblmensaje.Text = "Usted no cumple con el requisito de Notas aprobadas. Por favor, acérquese al área de secretaria.";
            }
            else
            {
                bibli = 1;
                lblmensaje.Text = "El Alumno no tiene devoluciones pendientes.";
            }
            validar_fini();
        }


        protected void btnestadoD_Click(object sender, EventArgs e)
        {
            if (ws.ListarPagos(cod_alumno).Count() > 0)
            {
                deud = 0;
                lblmensaje.Text = "Usted no cumple con el requisito de Notas aprobadas. Por favor, acérquese al área de secretaria.";

            }
            else
            {
                deud = 1;
                lblmensaje.Text = "El Alumno no presenta ninguna deuda pendiente.";
            }
            validar_fini();
        }
        public void validar_fini()
        {
            //if (notas==1 && bibli==1 && deud==1)
            //{
            //    btnfinish.Enabled = true;
            //}
        }


        protected void btncancel_Click(object sender, EventArgs e)
        {
            pnl_mensajeFinal.Visible = true;
            //Response.Redirect("index.aspx");
        }

        protected void btn_aceptar_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }





    }
}