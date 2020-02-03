using airbnb.Class;
using airbnb.DAO;
using airbnb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class Connexion : BasePage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            try
            {
                DaoPersonne daoPersonne = new DaoPersonne();
                Personne personne = daoPersonne.GetClient(login, password);

                if (personne != null)
                {
                    //Récupération des liste contenus dans personne
                    personne.Favoris = daoPersonne.GetClientFavoris(personne);
                    personne.Reservations = daoPersonne.GetClientReservations(personne);
                    personne.Adresses = daoPersonne.GetClientAdresses(personne);

                    Session[Constant.UtilisateurSession] = personne;
                    Response.Redirect(Constant.PageReservations);
                }
                else
                {
                    Response.Redirect(Constant.PageCreerCompte);
                    //Remplacer à terme par un label
                }
            }
            catch(Exception ex)
            {
                ((SiteMaster)this.Page.Master).AddError(ex);
            }

            
            
        }
    }
}