using Laboratorio.Model;
using Laboratorio.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Pages
{
    public partial class RegEquipo : System.Web.UI.Page
    {
        public List<Equipo> Equipos;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Singleton.Instance.Equipos!=null)
            {
                this.Equipos = Singleton.Instance.Equipos;
            }
            else
            {
                this.Equipos = new List<Equipo>();
            }
            this.GridView1.DataSource = Equipos;
            this.GridView1.DataBind();
        }
        protected void btnRegEquipo_Click(object sender, EventArgs e)
        {
            Equipo oEquipo = new Equipo
            {
                ID = this.Equipos.Count + 1,
                Nombre=this.txtNombreEquipo.Text,
            };
            if (!FileUpload1.HasFile)
            {
                return;
            }
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Images/" + filename));
            this.txtNombreEquipo.Text = String.Empty;
            oEquipo.Imagen = "~/Images/" + filename;
            Equipos.Add(oEquipo);
            Singleton.Instance.Equipos = Equipos;
            this.GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Debug.Print("HelloWorld");
            int index = Convert.ToInt32(e.CommandArgument);
            Singleton.Instance.EquipoSeleccionado = Equipos[index];
            Response.Redirect("AddPlayers.aspx");
        }
    }
}