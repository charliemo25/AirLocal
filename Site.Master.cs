using airbnb.Class;
using airbnb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class SiteMaster : MasterPage
    {
        public Personne user;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            user = (Personne)Session[Constant.UtilisateurSession];

            //Partie droite de la navbar
            StringBuilder navUser = new StringBuilder();

            //Si l'utilisateur n'est pas connecté
            navUser.Clear();
            navUser.Append("<a class='nav-item nav-link' runat='server' href='Connexion'><i class='far fa-user'></i> Se connecter</a>");
            ltUser.Text = navUser.ToString();
            
            if (user != null)
            {
                //Mettre les lien avec les infos de l'utilisateur
                navUser.Clear();
                navUser.Append("<a class='nav-item nav-link' runat='server' href='#'> Bienvenue, " + user.Login + "</a>");
                ltUser.Text = navUser.ToString();
            }

        }

        public void AddError(Exception ex)
        {
            //Message envoyé sur la vue de la page
            string error = "Le site a eu un dysfonctionnemment, merci de réessayer ultérieurement.";

            //Traitement de l'erreur
        }
    }
}
