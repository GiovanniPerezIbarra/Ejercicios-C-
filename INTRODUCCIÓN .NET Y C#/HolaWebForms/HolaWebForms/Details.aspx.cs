using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HolaWebForms
{
    public partial class Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            iddetail.Text = id;
            string nombre = Request.QueryString["nombre"];
            nombredetail.Text = nombre;
            string clave = Request.QueryString["clave"];
            clavedetail.Text = clave;
        }
        protected void borrar_Click(object sender, EventArgs e)
        {

        }
    }
}