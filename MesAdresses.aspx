<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MesAdresses.aspx.cs" Inherits="airbnb.MesAdresses" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <section class="container border shadow mt-5 mb-5">
        <div class="row p-3">
            <!-- Lien -->
            <div class="col-3">
                <div class="nav flex-column nav-pills" id="v-pills-tab" role="tablist" aria-orientation="vertical">
                    <a class="nav-link active" id="v-pills-adresse-tab" data-toggle="pill" href="#v-pills-adresse" role="tab" aria-controls="v-pills-adresse" aria-selected="true">Mes adresses</a>
                    <a class="nav-link" id="v-pills-modifier-tab" data-toggle="pill" href="#v-pills-modifier" role="tab" aria-controls="v-pills-modifier" aria-selected="false">Modifier une adresse</a>
                    <a class="nav-link" id="v-pills-ajout-tab" data-toggle="pill" href="#v-pills-ajout" role="tab" aria-controls="v-pills-ajout" aria-selected="false">Ajouter une adresse</a>
                </div>
            </div>
            <!-- Contenu -->
            <div class="col-9">
                <div class="tab-content" id="v-pills-tabContent">
                    <!-- Affichage des adresses / suppression -->
                    <div class="tab-pane fade show active" id="v-pills-adresse" role="tabpanel" aria-labelledby="v-pills-adresse-tab">
                        <!-- Liste des adresses -->
                        <asp:ListView ID="lvwAdresses" runat="server">
                            <ItemTemplate>
                                <div class="card m-3  border rounded bg-light">
                                    <div class="row no-gutters">
                                        <div class="col-md-8">
                                            <div class="card-body">
                                                <h3><%#Eval("NomAdresse")%></h3>
                                                <p><%# Eval("CodePostal")%> <%# Eval("Ville")%></p>
                                                <p><%#Eval("Numero")%> <%# Eval("Voie")%></p>
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="d-flex flex-column align-items-center">
                                                <asp:Button ID="btnModifier" CssClass="btn btn-primary m-2" runat="server" Text="Modifier" OnClick="btnModifier_Click" />
                                                <asp:Button ID="btnSupprimer" CssClass="btn btn-danger m-2" runat="server" Text="Supprimer" CommandArgument=<%# Eval("IdAdresse") %> OnClick="btnSupprimer_Click" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                    <!-- Modification d'une adresse -->
                    <div class="tab-pane fade" id="v-pills-modifier" role="tabpanel" aria-labelledby="v-pills-modifier-tab">
                        Modifier
                    </div>
                    <!-- Ajout d'une adresse -->
                    <div class="tab-pane fade" id="v-pills-ajout" role="tabpanel" aria-labelledby="v-pills-ajout-tab">
                        <div class="formulaire d-flex flex-column align-items-center ">
                            <!-- Nom de l'adresse-->
                            <div class="form-group ">
                                <label for="txtNomAdresse">Nom de l'adresse</label>
                                <asp:TextBox ID="txtNomAdresse" runat="server" Text="" class="form-control"></asp:TextBox>
                            </div>
                            <!-- Numero -->
                            <div class="form-group ">
                                <label for="txtNumero">Numéro de l'adresse</label>
                                <asp:TextBox ID="txtNumero" runat="server"  Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Voie -->
                            <div class="form-group ">
                                <label for="txtVoie">Voie</label>
                                <asp:TextBox ID="txtVoie" runat="server"  Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Code Postal -->
                            <div class="form-group ">
                                <label for="txtCP">Code Postal</label>
                                <asp:TextBox ID="txtCP" runat="server"  Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <!-- Ville -->
                            <div class="form-group ">
                                <label for="txtVille">Ville</label>
                                <asp:TextBox ID="txtVille" runat="server"  Text="" CssClass="form-control"></asp:TextBox>
                            </div>
                            <asp:Button ID="btnAjouter" class="btn btn-primary" runat="server" Text="Ajouter une adresse" OnClick="btnAjouter_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

</asp:Content>
