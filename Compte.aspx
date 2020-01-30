<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Compte.aspx.cs" Inherits="airbnb.Compte" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5 mb-5" id="Compte">
        <div class="row">
            <div class="col-12 col-sm-10 offset-sm-1 col-md-8 offset-md-2 col-lg-6 offset-lg-3">
                <div class="formulaire d-flex flex-column align-items-center border shadow p-3">
                    <fieldset class="name" disabled>
                        <!-- Nom -->
                        <div class="form-group ">
                            <label for="txtNom">Nom</label>
                            <asp:TextBox ID="txtNom" runat="server" CssClass="form-control  "></asp:TextBox>
                        </div>
                        <!-- Prenom -->
                        <div class="form-group ">
                            <label for="txtPrenom">Prenom</label>
                            <asp:TextBox ID="txtPrenom" runat="server" CssClass="form-control  "></asp:TextBox>
                        </div>
                    </fieldset>
                    <fieldset class="infos" disabled>
                        <!-- Email -->
                        <div class="form-group ">
                            <label for="txtMail">Email</label>
                            <asp:TextBox ID="txtMail" runat="server" TextMode="Email" CssClass="form-control "></asp:TextBox>
                        </div>
                        <!-- Telephone -->
                        <div class="form-group ">
                            <label for="txtTel">Telephone</label>
                            <asp:TextBox ID="txtTel" runat="server" CssClass="form-control  "></asp:TextBox>
                        </div>
                        <!-- Mot de passe (nouveau)-->
                        <div class="form-group">
                            <label for="txtPassword">Nouveau mot de passe</label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Veuillez saisir un mdp"></asp:RequiredFieldValidator>
                        </div>
                        <div class="form-group">
                            <%--<label for="txtPassword2">Veuillez saisir votre mot de passe à nouveau</label>--%>
                            <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword2" ErrorMessage="Veuillez saisir un mdp"></asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtPassword2" ErrorMessage="Veuillez saisir le meme mdp"></asp:CompareValidator>
                        </div>
                    </fieldset>
                    <div class="d-flex align-items-right">
                        <asp:Button ID="btnValider" CssClass="btn btn-success" runat="server" Text="Valider" OnClick="btnValider_Click" />
                        <button class="modifier btn btn-info" type="button">Modifier</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {

            $(".modifier").click(function () {
                //Devient modifiable
                if ($(".infos").attr("disabled")) {
                    $('.infos').prop('disabled', false);
                    $('.<%=btnValider.ClientID%>').prop('disabled', false);
                }
                //Plus modifiable
                else {
                    $('.infos').prop('disabled', true);
                    $('.<%=btnValider.ClientID%>').prop('disabled', true);
                }

            });

        });
    </script>
</asp:Content>
