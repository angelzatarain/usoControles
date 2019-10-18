using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace usoControles1
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddColores.Items.Count == 0)
            {
                ddColores.Items.Add("Rojo");
                ddColores.Items.Add("Verde");
                ddColores.Items.Add("Rosa");
                ddColores.Items.Add("Amarillo");
            }
            if (rbSabores.Items.Count == 0)
            {
                rbSabores.Items.Add("Vainilla");
                rbSabores.Items.Add("Fresa");
                rbSabores.Items.Add("Chocolate");
            }

            if (cbCafe.Items.Count == 0)
            {
                cbCafe.Items.Add("americano");
                cbCafe.Items.Add("capuccino");
                cbCafe.Items.Add("café de olla");
            }
        }

        protected void ddColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seleccion = 0;
            seleccion = ddColores.SelectedIndex;
            lbColores.Text = "indice seleccionado: " + seleccion.ToString();

            Session["controles"] = "cambio al DropDownList";
            lbSesion.Text = Session["controles"].ToString();
        }

        protected void rbSabores_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbIndiceS.Text = "indice seleccionado: " + rbSabores.SelectedIndex.ToString();
            lbContenidoS.Text = "contenido seleccionado: " + rbSabores.SelectedValue.ToString();

            Session["controles"] = "cambio al RadioButtonList";
            lbSesion.Text = Session["controles"].ToString();
        }

        protected void cbCafe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            ListBox1.Items.Clear();
            ListBox2.Items.Clear();
            for(i=0; i<cbCafe.Items.Count; i++)
            {
                if (cbCafe.Items[i].Selected == true)
                {
                    ListBox1.Items.Add(i.ToString());
                    ListBox2.Items.Add(cbCafe.Items[i].Value.ToString());
                }
                    
            }

            Session["controles"] = "cambio al CheckBoxList";
            lbSesion.Text = Session["controles"].ToString();
        }
    }
}