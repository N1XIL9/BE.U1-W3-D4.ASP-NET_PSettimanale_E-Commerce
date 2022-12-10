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
            string Id = Request.QueryString["Id"].ToString() ;

            foreach (Prodotto p in Prodotto.GetProdotto())
            {
                if(Id == p.Id.ToString() ) 
                {
                    Image1.ImageUrl = p.Immagine;
                    Nome.Text = p.NomeProdotto;
                    Descrizione.Text = p.Descrizione;
                }
                
            }
        }
    }
}