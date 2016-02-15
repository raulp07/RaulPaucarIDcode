using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoIDCode.WSMatricula;
using System.Collections.Generic;
using System.Net;
using System.IO;
using ProyectoIDCode.CLASES;
using System.Web.Script.Serialization;

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

                Session["cod_alumno"] =  cod_alumno.ToString();
                btnfinish.Visible = false;
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
            
            Respuesta resp = ws.ListarNotaAlumno(cod_alumno);
            lblmensaje.Text = resp.mensaje;
            notas = resp.flag;
            des_continuar();
            validar_fini();
        }

        protected void btndevolucion_Click(object sender, EventArgs e)
        {

            HttpWebRequest req1 = (HttpWebRequest)WebRequest
                .Create("http://localhost:4920/LibrosService.svc/LibrosPendientes/a100");
            req1.Method = "GET";
            HttpWebResponse res1 = null;
           
                res1 = (HttpWebResponse)req1.GetResponse();
                StreamReader reader1 = new StreamReader(res1.GetResponseStream());
                string alumnosJson1 = reader1.ReadToEnd();
                JavaScriptSerializer js1 = new JavaScriptSerializer();
                List<LibroPendiente> librosObtenidos = js1.Deserialize<List<LibroPendiente>>(alumnosJson1);

                if (librosObtenidos.ToList().Count()>0)
                {
                    lblmensaje.Text = "Usted cuenta con libros pendientes por devolver. Por favor, acérquese a la biblioteca.";




                }
                else
                {
                    lblmensaje.Text = "El Alumno no tiene devoluciones pendientes.";
                }


            //Respuesta resp = ws.ListarLibrosPrestados(cod_alumno);
            //lblmensaje.Text = resp.mensaje;
            //bibli = resp.flag;
            des_biblio();
            validar_fini();
        }


        protected void btnestadoD_Click(object sender, EventArgs e)
        {
            Respuesta resp = ws.ListarPagos(cod_alumno);
            lblmensaje.Text = resp.mensaje;
            deud = resp.flag;
            des_deudas();
            validar_fini();
        }
        public void validar_fini()
        {
            if (notas == 1 && bibli == 1 && deud == 1)
            {
                btnfinish.Visible = true;
            }
        }

        public void des_continuar()
        {
            if (notas == 1)
            {
                btcontinuar.Visible = true;
            }
            else
            {
                btcontinuar.Visible = false;
            }
        }
        public void des_biblio()
        {
            if (bibli == 1)
            {
                btcontinuar.Visible = true;
            }
            else
            {
                btcontinuar.Visible = false;
            }
        }
        public void des_deudas()
        {
            if (deud == 1)
            {
                btcontinuar.Visible = true;
            }
            else
            {
                btcontinuar.Visible = false;
            }
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