<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreerCompte.aspx.cs" Inherits="airbnb.CreerCompte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="formulaire d-flex flex-column align-items-center border shadow p-3">
            <!-- Nom -->
            <div class="form-group">
                <label for="txtNom">Nom</label>
                <asp:TextBox ID="txtNom" class="form-control" placeholder="Votre Nom" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Veuillez saisir votre nom" ControlToValidate="txtNom" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
            <!-- Prénom -->
            <div class="form-group">
                <label for="txtPrenom">Prénom</label>
                <asp:TextBox ID="txtPrenom" class="form-control" placeholder="Votre Prénom" runat="server"></asp:TextBox>
            </div>
            <!-- Email -->
            <div class="form-group">
                <label for="txtEmail">Email</label>
                <asp:TextBox ID="txtEmail" class="form-control" placeholder="exemple@gmail.com" runat="server"></asp:TextBox>
            </div>
            <!-- Nom Adresse -->
            <div class="form-group ">
                <label for="txtNomAdresse">Nom de l'adresse(facultatif)</label>
                <asp:TextBox ID="txtNomAdresse" class="form-control" placeholder="Ma maison" runat="server"></asp:TextBox>
            </div>
            <!-- Numero-->
            <div class="form-group ">
                <label for="txtNumero">Numéro de la voie</label>
                <asp:TextBox ID="txtNumero" class="form-control" runat="server"></asp:TextBox>
            </div>
            <!-- Voie-->
            <div class="form-group ">
                <label for="txtVoie">Voie</label>
                <asp:TextBox ID="txtVoie" class="form-control" placeholder="Boulevard de la Vie" runat="server"></asp:TextBox>
            </div>
            <!-- Ville -->
            <div class="form-group ">
                <label for="txtVille">Ville</label>
                <asp:TextBox ID="txtVille" class="form-control" placeholder="Votre Ville" runat="server"></asp:TextBox>
            </div>
            <!-- Code Postal -->
            <div class="form-group ">
                <label for="txtCP">Code Postal</label>
                <asp:TextBox ID="txtCP" class="form-control" placeholder="Votre code postal" runat="server"></asp:TextBox>
            </div>
            <!-- Telephone -->
            <div class="form-group">
                <label for="txtTel">Telephone</label>
                <asp:TextBox ID="txtTel" class="form-control" placeholder="Votre telephone" runat="server"></asp:TextBox>
            </div>
            <!-- Login -->
            <div class="form-group">
                <label for="txtLogin">Login</label>
                <asp:TextBox ID="txtLogin" runat="server" class="form-control"></asp:TextBox>
            </div>
            <!-- Password -->
            <div class="form-group">
                <label for="txtPassword">Mot de passe</label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Veuillez saisir un mdp"></asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <%--<label for="txtPassword2">Veuillez saisir votre mot de passe à nouveau</label>--%>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword2" ErrorMessage="Veuillez saisir un mdp"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" ErrorMessage="Veuillez saisir le meme mdp"></asp:CompareValidator>
            </div>

            <div class="text-center w-50">
                <asp:Button ID="btnEnvoyer" class="btn btn-primary " runat="server" Text="Envoyer" OnClick="btnEnvoyer_Click" />
            </div>
        </div>
    </div>
</asp:Content>
