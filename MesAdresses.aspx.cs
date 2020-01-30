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
    public partial class MesAdresses : UserLogged
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (user != null)
            {
                //Afficher les adresses
                if (!IsPostBack)
                {
                    //Utiliser une listView
                    lvwAdresses.DataSource = user.Adresse;
                    lvwAdresses.DataBind();
                }

                //Suite

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {

        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(((Button)sender).CommandArgument);
            new DaoPersonne().DeleteAdresse(user, id);

            //On réassigne les adresses à l'utilisateur
            user.Adresse = new DaoPersonne().GetClientAdresses(user);
            Response.Redirect(Constant.PageMesAdresses);
        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            new DaoPersonne().AddAdresse(user, txtNomAdresse.Text, txtNumero.Text, txtVoie.Text, txtCP.Text, txtVille.Text);

            //On réassigne les adresses à l'utilisateur
            user.Adresse = new DaoPersonne().GetClientAdresses(user);
            Response.Redirect(Constant.PageMesAdresses);
        }
    }
}