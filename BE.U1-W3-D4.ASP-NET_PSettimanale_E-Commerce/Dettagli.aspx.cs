using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"] ;

            foreach (Prodotto p in Prodotto.GetProdotto())
            {
                if(id == p.Id.ToString() ) 
                {
                    Image1.ImageUrl = p.Immagine;
                    Nome.Text = p.NomeProdotto;
                    Descrizione.Text = p.Descrizione;
                    Prezzo.Text = p.Prezzo.ToString("c2");
                }
                
            }
        }
        protected void AddProduct_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["Id"];


            foreach (Prodotto a in Prodotto.GetProdotto())
            {
                if (id == a.Id.ToString())
                {
                    Prodotto.listaCarrello.Add(a);
                    Prodotto.TotCarrello += a.Prezzo;
                }
            }
        }

        protected void GoCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }

    }
}