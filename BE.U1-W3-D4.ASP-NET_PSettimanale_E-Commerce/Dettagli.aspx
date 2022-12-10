<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce.Dettagli" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-3">
                <asp:Image ID="Image1" runat="server" />
            </div>
            <div class="col-9">
                <div class="card-body">
                    <asp:Label ID="Nome" runat="server" Text="Label"></asp:Label>
                    <asp:Label ID="Descrizione" runat="server" Text="Label"></asp:Label>

                    <div class="d-flex flex-column align-items-center">
                        <div class="btn-group">
                            
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
