<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModifierAdresse.aspx.cs" Inherits="airbnb.ModifierAdresse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="container">
        <div class="formulaire d-flex flex-column align-items-center ">
                            <!-- Nom de l'adresse-->
                            <div class="form-group ">
                                <label for="txtNomAdresse">Nom de l'adresse</label>
                                <asp:TextBox ID="txtNomAdresse" runat="server" Text="" class="form-control"></asp:TextBox>
                            </div>
                            <!-- Numero -->
                            <div class="form-group ">
                                <label for="txtNumero">Numéro de l'adresse</label>
                                <asp:TextBox ID="txtNumero" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Voie -->
                            <div class="form-group ">
                                <label for="txtVoie">Voie</label>
                                <asp:TextBox ID="txtVoie" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Code Postal -->
                            <div class="form-group ">
                                <label for="txtCP">Code Postal</label>
                                <asp:TextBox ID="txtCP" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Ville -->
                            <div class="form-group ">
                                <label for="txtVille">Ville</label>
                                <asp:TextBox ID="txtVille" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <asp:Button ID="btnModifier" class="btn btn-primary" runat="server" Text="Modifier" OnClick="btnModifier_Click" />
                        </div>
    </section>
</asp:Content>
