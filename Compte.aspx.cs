using airbnb.Class;
using airbnb.DAO;
using airbnb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class Compte : UserLogged
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if(user != null)
            {

                if (!IsPostBack)
                {
                    //Infos utilisateur
                    txtNom.Text = user.Nom;
                    txtPrenom.Text = user.Prenom;
                    txtMail.Text = user.Email;
                    txtTel.Text = user.Telephone;

                }

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }

        protected void btnValider_Click(object sender, EventArgs e)
        {


            //Verifier les infos rentrées par l'utilisateur si vide
            string tel = txtTel.Text ;
            string mail = txtMail.Text;

            //Verification différente à faire pour le mot de passe
            string password = txtPassword.Text;

            new DaoPersonne().UpdateClient(user, tel, mail, password);
            Response.Redirect(Constant.PageCompte);

        }
    }
}