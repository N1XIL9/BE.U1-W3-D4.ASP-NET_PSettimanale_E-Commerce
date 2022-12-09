using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce
{
    public partial class homePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              foreach (Prodotto p in Prodotto.GetProdotto())
                {
                    lblCardProdotto.Text = $" <div class=\"col\">\r\n" +
                        $"<div class=\"card shadow-sm\">\r\n" +
                        $"<div class=\"img-cont\">\r\n" +
                        $"<img class=\"bd-placeholder-img card-img-top\" src=\"img/1.png\" role=\"img\" focusable=\"false\" />\r\n" +
                        $"</div>\r\n\r\n\r\n" +
                        $"<div class=\"card-body\">\r\n" +
                        $"<p class=\"card-text\">Apple Wacth 44mm - White.</p>\r\n" +
                        $"<div class=\"d-flex justify-content-between align-items-center\">\r\n" +
                        $" <div class=\"btn-group\">\r\n                                        " +
                        $"<asp:Button ID=\"Button1\" runat=\"server\" Text=\"Dettagli\" OnClick=\"Button1_Click\" />\r\n" +
                        $"</div>\r\n" +
                        $"</div>\r\n" +
                        $"</div>\r\n" +
                        $"</div>\r\n" +
                        $"</div>";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}