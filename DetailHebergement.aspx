<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailHebergement.aspx.cs" Inherits="airbnb.DetailHebergement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container" id="details">
        <div class="row">
            <div class="col-12 col-sm-6 p-2">
                <img class=" img-fluid rounded" src="images/<%= hebergement.Photo %>" alt="..." />
            </div>
            <div class="col-12 col-sm-6">
                <h3><%= hebergement.Nom %></h3>
                <p><%= hebergement.Description %></p>
                <p><%= hebergement.Adresse.Numero +" "+ hebergement.Adresse.Voie %></p>
                <p><%= hebergement.Adresse.CodePostal +" "+ hebergement.Adresse.Ville %></p>
                <p><%= hebergement.Type %></p>
                <p><%= hebergement.Prix %>€ / nuit</p>
            </div>
        </div>
    </div>
    <div class="container" id="formReserv">
        <div class="form-row align-items-center">
            <!-- Date de début de reservation -->
            <div class="col-auto">
                <asp:TextBox ID="txtDateDebut" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <!-- Date de début de fin -->
            <div class="col-auto">
                <asp:TextBox ID="txtDateFin" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <!-- validation de la réservation -->
            <div class="col-auto">
                <asp:LinkButton ID="lbReserver" OnClick="btnReserver_Click" CssClass="btn btn-primary" runat="server"> Reservation</asp:LinkButton>
            </div>
            <!-- Favoris -->
            <div class="col-auto">
                <asp:LinkButton ID="lbFavoris" OnClick="btnFavoris_Click" CssClass="btn btn-primary" runat="server"> Favoris<i class="far fa-star"></i></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
