<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="airbnb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <div id="carouselExampleCaptions" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleCaptions" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="1"></li>
            <li data-target="#carouselExampleCaptions" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <asp:LinkButton ID="lbHebergement1" CommandArgument="1" OnClick="lbHebergement1_Click"  runat="server">
                    <img src="images/location1.jpg" class="d-block img-fluid w-100 imgCarousel"  alt="...">
                </asp:LinkButton>
                <div class="carousel-caption d-none d-md-block">
                    <h5>Maison du Lac</h5>
                    <p>Une résidence de luxe dans l'Est de la france !</p>
                </div>
            </div>
            <div class="carousel-item">
                <asp:LinkButton ID="lbHebergement2" runat="server" CommandArgument="2" OnClick="lbHebergement1_Click">
                    <img src="images/location2.jpg" class="d-block w-100 img-fluid"  alt="...">
                </asp:LinkButton>
                <div class="carousel-caption d-none d-md-block">
                    <h5>Second slide label</h5>
                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                </div>
            </div>
            <div class="carousel-item">
                <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument="3" OnClick="lbHebergement1_Click">
                    <img src="images/location3.jpg" class="d-block w-100 img-fluid"  alt="...">
                </asp:LinkButton>
                <div class="carousel-caption d-none d-md-block">
                    <h5>Third slide label</h5>
                    <p>Praesent commodo cursus magna, vel scelerisque nisl consectetur.</p>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleCaptions" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleCaptions" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <div id="form" class="row m-2">
        <div class="form-group m-2">
            <asp:DropDownList CssClass="form-control" ID="ddlDepartement" runat="server">
                <asp:ListItem Selected Value="" Text="Selectionner"></asp:ListItem>
                <asp:ListItem Value="01" Text="01 Ain"></asp:ListItem>
                <asp:ListItem Value="02" Text="02 Aisne"></asp:ListItem>
                <asp:ListItem Value="03" Text="03 Allier"></asp:ListItem>
                <asp:ListItem Value="04" Text="04 Alpes de Haute Provence"></asp:ListItem>
                <asp:ListItem Value="05" Text="05 Hautes Alpes"></asp:ListItem>
                <asp:ListItem Value="06" Text="06 Alpes Maritimes"></asp:ListItem>
                <asp:ListItem Value="07" Text="07 Ardèche"></asp:ListItem>
                <asp:ListItem Value="08" Text="08 Ardennes"></asp:ListItem>
                <asp:ListItem Value="09" Text="09 Ariège"></asp:ListItem>
                <asp:ListItem Value="10" Text="10 Aube"></asp:ListItem>
                <asp:ListItem Value="11" Text="11 Aude"></asp:ListItem>
                <asp:ListItem Value="12" Text="12 Aveyron"></asp:ListItem>
                <asp:ListItem Value="13" Text="13 Bouches du Rhône"></asp:ListItem>
                <asp:ListItem Value="14" Text="14 Calvados"></asp:ListItem>
                <asp:ListItem Value="15" Text="15 Cantal"></asp:ListItem>
                <asp:ListItem Value="16" Text="16 Charente"></asp:ListItem>
                <asp:ListItem Value="2A" Text="2A Corse du Sud"></asp:ListItem>
                <asp:ListItem Value="41" Text="41 Loir et Cher"></asp:ListItem>
                <asp:ListItem Value="51" Text="51 Marne"></asp:ListItem>
                <asp:ListItem Value="17" Text="17 Charente Maritime"></asp:ListItem>
                <asp:ListItem Value="18" Text="18 Cher"></asp:ListItem>
                <asp:ListItem Value="19" Text="19 Corrèze"></asp:ListItem>
                <asp:ListItem Value="21" Text="21 Côte d'Or"></asp:ListItem>
                <asp:ListItem Value="22" Text="22 Côtes d'Armor"></asp:ListItem>
                <asp:ListItem Value="23" Text="23 Creuse"></asp:ListItem>
                <asp:ListItem Value="24" Text="24 Dordogne"></asp:ListItem>
                <asp:ListItem Value="25" Text="25 Doubs"></asp:ListItem>
                <asp:ListItem Value="26" Text="26 Drôme"></asp:ListItem>
                <asp:ListItem Value="27" Text="27 Eure"></asp:ListItem>
                <asp:ListItem Value="28" Text="28 Eure et Loir"></asp:ListItem>
                <asp:ListItem Value="29" Text="29 Finistère"></asp:ListItem>
                <asp:ListItem Value="2B" Text="2B Haute-Corse"></asp:ListItem>
                <asp:ListItem Value="30" Text="30 Gard"></asp:ListItem>
                <asp:ListItem Value="31" Text="31 Haute Garonne"></asp:ListItem>
                <asp:ListItem Value="53" Text="53 Mayenne"></asp:ListItem>
                <asp:ListItem Value="60" Text="60 Oise"></asp:ListItem>
                <asp:ListItem Value="61" Text="61 Orne"></asp:ListItem>
                <asp:ListItem Value="32" Text="32 Gers"></asp:ListItem>
                <asp:ListItem Value="33" Text="33 Gironde"></asp:ListItem>
                <asp:ListItem Value="34" Text="34 Hérault"></asp:ListItem>
                <asp:ListItem Value="35" Text="35 Ille et Vilaine"></asp:ListItem>
                <asp:ListItem Value="36" Text="36 Indre"></asp:ListItem>
                <asp:ListItem Value="37" Text="37 Indre et Loire"></asp:ListItem>
                <asp:ListItem Value="38" Text="38 Isère"></asp:ListItem>
                <asp:ListItem Value="39" Text="39 Jura"></asp:ListItem>
                <asp:ListItem Value="40" Text="40 Landes"></asp:ListItem>
                <asp:ListItem Value="42" Text="42 Loire"></asp:ListItem>
                <asp:ListItem Value="43" Text="43 Haute Loire"></asp:ListItem>
                <asp:ListItem Value="44" Text="44 Loire Atlantique"></asp:ListItem>
                <asp:ListItem Value="45" Text="45 Loiret"></asp:ListItem>
                <asp:ListItem Value="46" Text="46 Lot"></asp:ListItem>
                <asp:ListItem Value="47" Text="47 Lot et Garonne"></asp:ListItem>
                <asp:ListItem Value="63" Text="63 Puy de Dôme"></asp:ListItem>
                <asp:ListItem Value="80" Text="80 Somme"></asp:ListItem>
                <asp:ListItem Value="81" Text="81 Tarn"></asp:ListItem>
                <asp:ListItem Value="48" Text="48 Lozère"></asp:ListItem>
                <asp:ListItem Value="49" Text="49 Maine et Loire"></asp:ListItem>
                <asp:ListItem Value="50" Text="50 Manche"></asp:ListItem>
                <asp:ListItem Value="52" Text="52 Haute Marne"></asp:ListItem>
                <asp:ListItem Value="54" Text="54 Meurthe et Moselle"></asp:ListItem>
                <asp:ListItem Value="55" Text="55 Meuse"></asp:ListItem>
                <asp:ListItem Value="56" Text="56 Morbihan"></asp:ListItem>
                <asp:ListItem Value="57" Text="57 Moselle"></asp:ListItem>
                <asp:ListItem Value="58" Text="58 Nièvre"></asp:ListItem>
                <asp:ListItem Value="59" Text="59 Nord"></asp:ListItem>
                <asp:ListItem Value="62" Text="62 Pas de Calais"></asp:ListItem>
                <asp:ListItem Value="64" Text="64 Pyrénées Atlantiques"></asp:ListItem>
                <asp:ListItem Value="65" Text="65 Hautes Pyrénées"></asp:ListItem>
                <asp:ListItem Value="66" Text="66 Pyrénées Orientales"></asp:ListItem>
                <asp:ListItem Value="67" Text="67 Bas Rhin"></asp:ListItem>
                <asp:ListItem Value="68" Text="68 Haut Rhin"></asp:ListItem>
                <asp:ListItem Value="70" Text="70 Haute Saône"></asp:ListItem>
                <asp:ListItem Value="71" Text="71 Saône et Loire"></asp:ListItem>
                <asp:ListItem Value="69" Text="69 Rhône"></asp:ListItem>
                <asp:ListItem Value="72" Text="72 Sarthe"></asp:ListItem>
                <asp:ListItem Value="73" Text="73 Savoie"></asp:ListItem>
                <asp:ListItem Value="74" Text="74 Haute Savoie"></asp:ListItem>
                <asp:ListItem Value="75" Text="75 Paris"></asp:ListItem>
                <asp:ListItem Value="76" Text="76 Seine Maritime"></asp:ListItem>
                <asp:ListItem Value="77" Text="77 Seine et Marne"></asp:ListItem>
                <asp:ListItem Value="78" Text="78 Yvelines"></asp:ListItem>
                <asp:ListItem Value="79" Text="79 Deux Sèvres"></asp:ListItem>
                <asp:ListItem Value="82" Text="82 Tarn et Garonne"></asp:ListItem>
                <asp:ListItem Value="83" Text="83 Var"></asp:ListItem>
                <asp:ListItem Value="84" Text="84 Vaucluse"></asp:ListItem>
                <asp:ListItem Value="85" Text="85 Vendée"></asp:ListItem>
                <asp:ListItem Value="86" Text="86 Vienne"></asp:ListItem>
                <asp:ListItem Value="87" Text="87 Haute Vienne"></asp:ListItem>
                <asp:ListItem Value="88" Text="88 Vosges"></asp:ListItem>
                <asp:ListItem Value="973" Text="973 Guyane"></asp:ListItem>
                <asp:ListItem Value="976" Text="976 Mayotte"></asp:ListItem>
                <asp:ListItem Value="89" Text="89 Yonne"></asp:ListItem>
                <asp:ListItem Value="90" Text="90 Territoire de Belfort"></asp:ListItem>
                <asp:ListItem Value="91" Text="91 Essonne"></asp:ListItem>
                <asp:ListItem Value="92" Text="92 Hauts de Seine"></asp:ListItem>
                <asp:ListItem Value="93" Text="93 Seine Saint Denis"></asp:ListItem>
                <asp:ListItem Value="94" Text="94 Val de Marne"></asp:ListItem>
                <asp:ListItem Value="95" Text="95 Val d'Oise"></asp:ListItem>
                <asp:ListItem Value="971" Text="971 Guadeloupe"></asp:ListItem>
                <asp:ListItem Value="972" Text="972 Martinique"></asp:ListItem>
                <asp:ListItem Value="974" Text="974 Réunion"></asp:ListItem>
                <asp:ListItem Value="975" Text="975 Saint Pierre et Miquelon"></asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-group m-2">
            <asp:DropDownList ID="ddlTypeHebergement" CssClass="form-control" runat="server">
                <asp:ListItem Selected Value="" Text="Selectionner"></asp:ListItem>
                <asp:ListItem Value="chambre" Text="Chambre"></asp:ListItem>
                <asp:ListItem Value="appartement" Text="Appartement"></asp:ListItem>
                <asp:ListItem Value="maison" Text="Maison"></asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class=" form-group m-2">
            <asp:Button ID="btnEnvoyer" class="btn btn-primary" runat="server" Text="Envoyer" OnClick="btnEnvoyer_Click" />
        </div>
    </div>


</asp:Content>
