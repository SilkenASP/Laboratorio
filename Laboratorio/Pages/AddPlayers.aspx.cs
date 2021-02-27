using Laboratorio.Model;
using Laboratorio.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Pages
{
    public partial class AddPlayers : System.Web.UI.Page
    {
        List<Jugador> Jugadores;
        Equipo oEquipo;
        protected void Page_Load(object sender, EventArgs e)
        {
            oEquipo = Singleton.Instance.EquipoSeleccionado;
            Jugadores = new List<Jugador>();
            if (oEquipo.Jugadores!=null )
            {
                Jugadores = oEquipo.Jugadores;
                if ((Jugadores.Count<5 || Jugadores.Count>15) && oEquipo.Jugadores.Count != 0)
                {
                    this.lblErrorMinMax.Text = "El equipo no es permitido, no cumple con los requisitos minimos o maximos";
                }
                else
                {
                    this.lblErrorMinMax.Text = "";
                }
            }
            else
            {
                oEquipo.Jugadores = new List<Jugador>();
            }
            GridView1.DataSource = Jugadores;
            GridView1.DataBind();
            if (Singleton.Instance.Universidades!=null)
            {
                this.dropUniversidades.DataSource = Singleton.Instance.Universidades;
                this.dropUniversidades.DataBind();
            }
        }

        protected void btnRegJugador_Click(object sender, EventArgs e)
        {
            if (Jugadores.Count>=15)
            {
                this.lblErrorMinMax.Text = "No se puede registrar otro jugador, el maximo ha sido alcanzado";
                return;
            }
            this.lblErroPos.Text = "";
            #region Validacion posiciones
            var ba = from item in oEquipo.Jugadores
                     where (item.Posicion.Equals("BA"))
                     select item;
            var ee = from item in oEquipo.Jugadores
                     where (item.Posicion.Equals("E"))
                     select item;
            var sf = from item in oEquipo.Jugadores
                     where (item.Posicion.Equals("SF"))
                     select item;
            var ap = from item in oEquipo.Jugadores
                     where (item.Posicion.Equals("AP"))
                     select item;
            var c = from item in oEquipo.Jugadores
                    where (item.Posicion.Equals("C"))
                    select item;

            if (dropPoscicion.SelectedValue.Split('-').LastOrDefault() == "BA" && (ba.Count() + 1) > 1)
            {
                //Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"El limite para Jugadores BA ha sido superado\")</SCRIPT>");
                this.lblErroPos.Text = "El limite para Jugadores BA ha sido superado";
                return;
            }
            if (dropPoscicion.SelectedValue.Split('-').LastOrDefault() == "E" && (ee.Count() + 1) > 2)
            {
                //Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"El limite para Jugadores E ha sido superado\")</SCRIPT>");
                this.lblErroPos.Text = "El limite para Jugadores E ha sido superado";
                return;
            }
            if (dropPoscicion.SelectedValue.Split('-').LastOrDefault() == "SF" && (sf.Count() + 1) > 3)
            {
                //Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"El limite para Jugadores SF ha sido superado\")</SCRIPT>");
                this.lblErroPos.Text = "El limite para Jugadores SF ha sido superado";
                return;
            }
            if (dropPoscicion.SelectedValue.Split('-').LastOrDefault() == "AP" && (ap.Count() + 1) > 4)
            {
                //Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"El limite para Jugadores AP ha sido superado\")</SCRIPT>");
                this.lblErroPos.Text = "El limite para Jugadores AP ha sido superado";
                return;
            }
            if (dropPoscicion.SelectedValue.Split('-').LastOrDefault() == "C" && (c.Count() + 1) > 5)
            {
                //Response.Write("<SCRIPT LANGUAGE=\"\"JavaScript\"\">alert(\"El limite para Jugadores C ha sido superado\")</SCRIPT>");
                this.lblErroPos.Text = "El limite para Jugadores C ha sido superado";
                return;
            }

            #endregion
            Jugador oJugador = new Jugador
            {
                Nombre = this.txtNombreJugador.Text,
                EstaturaMetros = Convert.ToDouble(this.txtEstatura.Text),
                Peso = Convert.ToDouble(this.txtPeso.Text),
                Edad = Convert.ToInt32(this.txtEdad.Text),
                Posicion = dropPoscicion.SelectedValue.Split('-').LastOrDefault(),
                Universidad = this.dropUniversidades.SelectedValue
            };
            if (!FileUpload1.HasFile)
            {
                return;
            }
            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/Images/" + filename));
            oJugador.Fotografia = "~/Images/" + filename;
            oEquipo.Jugadores.Add(oJugador);
            Singleton.Instance.Equipos[oEquipo.ID - 1] = oEquipo;
            Singleton.Instance.EquipoSeleccionado = oEquipo;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void imgButtonEditUniversities_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("RegUniversidad.aspx");
        }
    }
}