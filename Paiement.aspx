<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paiement.aspx.cs" Inherits="airbnb.Paiement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group">
        <div class="form-check-inline">
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control">
                <asp:ListItem Selected Text="Carte"></asp:ListItem>
                <asp:ListItem Text="Espece"></asp:ListItem>
                <asp:ListItem Text="Cheques"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
</asp:Content>
