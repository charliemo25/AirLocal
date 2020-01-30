<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreerHebergement.aspx.cs" Inherits="airbnb.CreerHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="formulaire d-flex flex-column align-items-center border shadow p-3">
            <!-- Nom -->
            <div class="form-group">
                <label for="txtNom">Nom de l'hebergement</label>
                <asp:TextBox ID="txtNom" class="form-control" placeholder="Nom de l'hebergement" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Veuillez saisir votre nom" ControlToValidate="txtNom" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
            <!-- Photo -->
            <div class="form-group">
                <asp:FileUpload ID="FileUpload1" CssClass="form-control-file" runat="server" />
                <hr />
                <asp:Image ID="imgUpload" runat="server" Height="100" Width="100" />
            </div>
            <!-- Type -->
            <div class="form-group">
                <label for="ddlType">Type d'hebergement</label>
                <asp:DropDownList ID="ddlType" CssClass="form-control" runat="server">
                    <asp:ListItem Selected Value="">Type de location</asp:ListItem>
                    <asp:ListItem Value="Chambre">Chambre</asp:ListItem>
                    <asp:ListItem Value="Appartement">Appartement</asp:ListItem>
                    <asp:ListItem Value="Maison">Maison</asp:ListItem>
                </asp:DropDownList>
            </div>
            <!-- Description -->
            <div class="form-group">
                <label for="txtDescription">Description</label>
                <asp:TextBox ID="txtDescription" CssClass="form-control" runat="server" TextMode="MultiLine"></asp:TextBox>
            </div>
            <!-- Prix -->
            <div class="form-group">
                <label for="txtPrix">Prix de la location par nuit</label>
                <asp:TextBox ID="txtPrix" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <!-- Nom de l'adresse -->
            <div class="form-group">
                <label for="txtNomAdresse">Nom de l'adresse(facultatif)</label>
                <asp:TextBox ID="txtNomAdresse" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!-- Numéro de l'adresse -->
            <div class="form-group">
                <label for="txtNumeroAdresse">n° de la rue</label>
                <asp:TextBox ID="txtNumeroAdresse" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!-- Voie-->
            <div class="form-group">
                <label for="txtVoie">Nom de la rue</label>
                <asp:TextBox ID="txtVoie" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!-- Code Postal -->
            <div class="form-group">
                <label for="txtCP">Code Postal</label>
                <asp:TextBox ID="txtCP" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <!-- Ville -->
            <div class="form-group">
                <label for="txtVille">Ville</label>
                <asp:TextBox ID="txtVille" runat="server" CssClass="form-control"></asp:TextBox>
            </div>


            <div class="text-center w-50">
                <asp:Button ID="btnEnvoyer" class="btn btn-primary " runat="server" Text="Envoyer" OnClick="btnEnvoyer_Click" />
            </div>
        </div>
    </div>

    <script type="text/javascript">

        function readURL(input) {
            if (input.files && input.files[0]) {
                var reader = new FileReader();

                reader.onload = function (e) {
                    $('#<%= imgUpload.ClientID %>').attr('src', e.target.result);
                }

                reader.readAsDataURL(input.files[0]);
            }
        }

        $('#<%= FileUpload1.ClientID %>').change(function () {
            readURL(this);
        });

    </script>
</asp:Content>
