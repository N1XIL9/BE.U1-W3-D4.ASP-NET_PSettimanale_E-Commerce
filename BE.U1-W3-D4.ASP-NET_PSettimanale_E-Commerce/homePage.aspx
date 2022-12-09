<%@ Page Title="" Language="C#" MasterPageFile="~/home.Master" AutoEventWireup="true" CodeBehind="homePage.aspx.cs" Inherits="BE.U1_W3_D4.ASP_NET_PSettimanale_E_Commerce.homePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <main>
        <div class="album py-5 bg-light">
            <div class="container-fluid">

                <div class="row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3">
                    <asp:Label ID="lblCardProdotto" runat="server" Text=""></asp:Label>
                    <div class="col">
                        <div class="card shadow-sm">
                            <div class="img-cont">
                                <img class="bd-placeholder-img card-img-top" src="img/1.png" role="img" focusable="false" />
                            </div>


                            <div class="card-body">
                                <p class="card-title"></p>

                                <h4 class="card-text text-center"></h4>
                                <div class="d-flex justify-content-between align-items-center">
                                    <div class="btn-group">
                                        <asp:Button ID="Button1" runat="server" Text="Dettagli" OnClick="Button1_Click" />                                       
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>                
                </div>
            </div>
        </div>

    </main>
</asp:Content>
