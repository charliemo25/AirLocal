<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reservations.aspx.cs" Inherits="airbnb.Reservations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="container mt-5 m-5">
        <asp:ListView ID="lvwReservations" runat="server">
        <ItemTemplate>
            <div class="card mb-3 shadow border rounded">
                <div class="row no-gutters">
                    <div class="col-md-4">
                        <img src="images/<%#Eval("Hebergement.Photo")%>"" class="card-img img-fluid p-1" alt="..." />
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Hebergement.Nom")%></h5>
                            <p class="card-text"><%#Eval("Hebergement.Description")%></p>
                            <p class="card-text"><%#Eval("Hebergement.Prix")%>€/Nuit</p>
                            <p class="card-text"> Date de la demande de réservation: <%# String.Format("{0:dd/MM/yyyy}", Eval("DateReservation")) %></p>
                            <p class="card-text"> Date de début: <%# String.Format("{0:dd/MM/yyyy}", Eval("DateDebut")) %></p>
                            <p class="card-text">Date de fin: <%# String.Format("{0:dd/MM/yyyy}", Eval("DateFin")) %></p>
                            <asp:Button ID="btnSupprimer" CssClass="btn btn-danger"  OnClick="btnSupprimer_Click" CommandArgument=<%#Eval("IdReservation") %> runat="server" Text="Supprimer" />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
    <p>Proceder à un paiement: <asp:Button ID="btnEnvoyer" class="btn btn-primary" runat="server" Text="Paiement" OnClick="btnEnvoyer_Click" /> </p>
    </section>
    </asp:Content>
