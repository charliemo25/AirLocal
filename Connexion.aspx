<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Connexion.aspx.cs" Inherits="airbnb.Connexion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="container mt-5 mb-5" id="Connexion">
        <div class="row">
            <div class="col-12 col-sm-10 offset-sm-1 col-md-8 offset-md-2 col-lg-6 offset-lg-3">
                <div class="formulaire d-flex flex-column align-items-center border shadow p-3">
                    <!-- Login / Password -->
                    <div class="form-group ">
                        <label for="txtLogin">Login</label>
                        <asp:TextBox ID="txtLogin" runat="server" Text="charlie25" class="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group ">
                        <label for="txtPassword">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Text="1234" CssClass="form-control"></asp:TextBox>
                    </div>

                    <a class="text-reset" href="CreerCompte">Créer un compte</a>
                    <div class="text-center m-3">
                        <asp:Button ID="btnEnvoyer" class="btn btn-primary" runat="server" Text="Se connecter" OnClick="btnEnvoyer_Click" />
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
