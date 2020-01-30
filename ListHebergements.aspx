<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListHebergements.aspx.cs" Inherits="airbnb.ListHebergements" %>
<%@ PreviousPageType VirtualPath="~/Default.aspx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="container mt-5 mb-5">
        <div class="row row-cols-1 row-cols-md-3">
            <asp:ListView ID="lvwHebergement" runat="server">
                <ItemTemplate>
                    <div class="col mb-4">
                        <div class="card h-100 border shadow ">
                            <img src="images/<%#Eval("Photo")%>" class="card-img-top thumbnail" alt="..." data-toggle="modal" data-target="#myModal">
                            <div class="card-body">
                                <h5 class="card-title">
                                    <asp:LinkButton ID="lbnom" runat="server" CssClass="text-reset" OnClick="btnNom_Click" CommandArgument='<%#Eval("IdHebergement")%>'><%#Eval("Nom")%></asp:LinkButton>
                                </h5>
                                <p class="card-text"><%#Eval("Type") %></p>
                                <p class="card-text"><%#Eval("Description")%></p>
                                <p class="card-text"><%#Eval("Prix")%>€/Nuit</p>
                                <asp:Button ID="btnFavoris" OnClick="btnFavoris_Click" CssClass="btn btn-primary" CommandArgument='<%#Eval("IdHebergement")%>' runat="server" Text="Favoris" />
                                <asp:Button ID="btnReserver" OnClick="btnReserver_Click" CssClass="btn btn-primary" runat="server" CommandArgument='<%#Eval("IdHebergement")%>' Text="Reserver" />

                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>

        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog modal-xl" role="document">
                <div class="modal-content">
                    <div class="modal-header p-3 mb-2 bg-info text-white">
                        <h5 class="modal-title" id="exampleModalLabel">cookies</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body text-center">
                        <img class="" id="imgModal" src="" alt="..." />
                    </div>
                    <%--<div class="modal-footer"></div>--%>
                </div>
            </div>
        </div>

    </section>

    <script>
        $(".thumbnail").click(function (e) {
            console.log("coucou")
            $("#imgModal").attr('src', $(".thumbnail").attr('src'))
        });
    </script>
</asp:Content>

