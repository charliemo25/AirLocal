<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Favoris.aspx.cs" Inherits="airbnb.Favoris" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ListView ID="lvwFavoris" runat="server">
        <ItemTemplate>
            <div class="card mb-3 shadow border rounded">
                <div class="row no-gutters">
                    <div class="col-md-4">
                        <img src="images/<%#Eval("Photo")%>"" class="card-img img-fluid p-1" alt="..." />
                    </div>
                    <div class="col-md-8">
                        <div class="card-body">
                            <h5 class="card-title"><%#Eval("Nom")%></h5>
                            <p class="card-text"><%#Eval("Description")%></p>
                            <p class="card-text"><%#Eval("Prix")%>€/Nuit</p>
                            <asp:Button ID="btnReserver" CssClass="btn btn-primary" OnClick="btnReserver_Click" CommandArgument=<%#Eval("IdHebergement") %> runat="server" Text="Reserver" />
                            <asp:Button ID="btnSupprimer" CssClass="btn btn-danger" OnClick="btnSupprimer_Click" CommandArgument=<%#Eval("IdHebergement") %> runat="server" Text="Supprimer" />
                        </div>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
