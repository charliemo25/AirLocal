using airbnb.Class;
using airbnb.DAO;
using airbnb.Entities;
using airbnb.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class DetailHebergement : BasePage
    {
        public Hebergement hebergement;
        public List<Hebergement> hebergements;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            hebergements = (List<Hebergement>)Session[Constant.LoadHebergement];

            //Récuperer l'id de l'hebergement dans l'url
            string idHebergement = Request["Hebergement"];
            int id = 0;

            //Test si idHebergement contient un entier puis réassigne la valeur à id
            if(!int.TryParse(idHebergement,out id))
            {
                //Gerer l'exception page 404
                Response.Redirect(Constant.PageListeHebergement);
            }

            //récuperation de l'hebergement avec son id
            DaoHebergement daoHebergement = new DaoHebergement();
            hebergement = daoHebergement.GetHebergement(id);
            
        }

        protected void btnFavoris_Click(object sender, EventArgs e)
        {
            if (user != null)
            {

                if (user.Favoris == null)
                {
                    user.Favoris = new List<Hebergement>();
                }

                var verifHebergement = user.Favoris.Where(x => x.IdHebergement == hebergement.IdHebergement);

                if (verifHebergement != null && verifHebergement.Count() == 0)
                {
                    Hebergement fav = hebergements.Single(x => x.IdHebergement == hebergement.IdHebergement);

                    DaoPersonne daoPersonne = new DaoPersonne();
                    daoPersonne.AddFavoris(user, fav);
                    Response.Redirect(Constant.PageFavoris);
                }
                else
                {

                    //Ajouter un label d'erreur si favoris existant
                }

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }

        protected void btnReserver_Click(object sender, EventArgs e)
        {

            if (user != null)
            {

                if (user.Reservations == null)
                {
                    user.Reservations = new List<Reservation>();
                }

                //Vérifie si une reservation existe, à modifier pour prendre en compte la date de reservation
                var verifhebergement = user.Reservations.Where(x => x.hebergement.IdHebergement == hebergement.IdHebergement);

                if (verifhebergement != null && verifhebergement.Count() == 0)
                {
                    
                    //reserv prend la valeur de l'hebergement selectionner
                    Hebergement reserv = hebergements.Single(x => x.IdHebergement == hebergement.IdHebergement);

                    DateTime reservDebut = DateTime.ParseExact(txtDateDebut.Text, "yyyy-mm-dd", CultureInfo.InvariantCulture);
                    DateTime reservFin = DateTime.ParseExact(txtDateFin.Text, "yyyy-mm-dd", CultureInfo.InvariantCulture);

                    //On ajoute la nouvelle reservation
                    DaoPersonne daoPersonne = new DaoPersonne();
                    daoPersonne.AddReservation(user, reserv, reservDebut, reservFin);

                    //On réassigne les réservations a l'utilisateur
                    user.Reservations = daoPersonne.GetClientReservations(user);

                    Response.Redirect(Constant.PageReservations);
                }
                else
                {
                    //Ajouter un label d'erreur si favoris existant
                }


            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }
    }
}