<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce.homePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="album py-5 bg-light">
            <div class="container-fluid">

                <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3">
                    <asp:Repeater ID="Repeater1" runat="server" ItemType="BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce.Prodotto">
                        <ItemTemplate>

                            <div class="col">
                                <div class="card shadow-sm">
                                    <div class="img-cont">
                                        
                                        <a href="Dettagli.aspx?Id=<%# Item.Id %>"> 
                                            <img class="card-img-top" src="<%# Item.Immagine %>" role="img"  />
                                        </a>
                                    </div>


                                    <div class="card-body">
                                        <p class="card-title text-center"><%# Item.NomeProdotto %></p>

                                        <h5 class="card-text text-center"> <%# Item.Prezzo.ToString("c2") %></h5>
                                        <div class="d-flex flex-column align-items-center">
                                            <div class="btn-group">
                                                <asp:Button ID="Button1" runat="server" Text="Aggiungi al carrello" OnClick="Button1_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>
        </div>

    </main>
</asp:Content>
