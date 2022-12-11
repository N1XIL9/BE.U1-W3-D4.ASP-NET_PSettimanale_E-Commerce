using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Prodotto.listaCarrello.Count == 0)
            {
                lblEmptyCart.Text = $" <a href=\"Default.aspx\">Il tuo carrello è vuoto... Torna alla pagina prodotti</a><hr />";
            }
            else
            {
                GridCarrello.DataSource = Prodotto.listaCarrello;
                GridCarrello.DataBind();
                lblTotCarrello.Text = $"{Prodotto.TotCarrello.ToString("c2")}";
            }
        }

        protected void Delete_Click(object sender, EventArgs e)
        {

            GridCarrello.Visible = false;
            Delete.Visible = false;
            Prodotto.listaCarrello.Clear();
            Prodotto.TotCarrello = 0;
            lblTotCarrello.Text = $"{Prodotto.TotCarrello.ToString("c2")}";
            lblEmptyCart.Text = $" <a href=\"homePage.aspx\">Il tuo carrello è vuoto... Torna alla pagina prodotti</a><hr />";
        }
    }
}