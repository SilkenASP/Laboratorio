using Laboratorio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio.Pages
{
    public partial class RegUniversidad : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cancelar.Attributes.Add("onClick", "javascript:history.back(); return false;");
        }

        protected void Guardar_Click(object sender, EventArgs e)
        {
            if (Singleton.Instance.Universidades==null)
            {
                Singleton.Instance.Universidades = new List<string>();
            }
            Singleton.Instance.Universidades.Add(this.txtNombreUniversidad.Text);
            Response.Redirect("AddPlayers.aspx");
        }
    }
}