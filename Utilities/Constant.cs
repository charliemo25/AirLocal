using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Utilities
{
    public class Constant
    {

        //Connexion à la base de données
        public const string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=AirLocal;Integrated Security=True";

        //Variable de Session :
        //Session de l'utilisateur avec ses favors, ses réservations et sa liste d'adresses
        public const string UtilisateurSession = "utilisateurSession";
        //Contient la liste de tous les hebergements
        public const string LoadHebergement = "loadHebergement";
        //Contient les details d'un hebergement
        public const string DetailsHebergement = "detailsHebergements";
        //Contient l'id d'une adresse
        public const string idAdresse = "";

        //Variable de Page :
        //Contient les nom des différentes pages du site: Page*
        public const string PageReservations = "Reservations.aspx";
        public const string PageConnexion = "Connexion.aspx";
        public const string PageFavoris = "Favoris.aspx";
        public const string PageCreerCompte = "CreerCompte.aspx";
        public const string PageDetailHebergement = "DetailHebergement.aspx";
        public const string PageListeHebergement = "ListHebergements.aspx";
        public const string PageCompte = "Compte.aspx";
        public const string PagePaiement = "Paiement.aspx";
        public const string PageMesAdresses = "MesAdresses.aspx";
        public const string PageModifierAdresse = "ModifierAdresse";

    }
}