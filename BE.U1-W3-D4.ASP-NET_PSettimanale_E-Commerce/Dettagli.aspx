<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
            <div class="card mb-3">
                <div class="row g-0">
                    <div class="col-4">
                        <asp:Image ID="Image1" runat="server" Width="200" />
                    </div>
                    <div class="col-8">
                        <div class="card-body mt-5">
                            <h2 class="card-title"><asp:Label ID="Nome" runat="server" Text="" Font-Bold="true" Font-Size="30px"></asp:Label></h2>
                            <p class="card-text"><asp:Label ID="Descrizione" runat="server" Text=""></asp:Label></p>
                            <p class="card-text">Prezzo: <asp:Label ID="Prezzo" runat="server" Text="" Font-Bold="true"></asp:Label></p>
                            <asp:Button ID="AddProduct" runat="server" Text="Aggiungi al Carrello" OnClick="AddProduct_Click" CssClass="border border-0 bg-opacity-10" />
                            <asp:Button ID="GoCart" runat="server" Text="Vai al Carrello" Onclick="GoCart_Click" CssClass="border border-0 bg-opacity-10"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
