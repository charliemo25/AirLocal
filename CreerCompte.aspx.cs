using airbnb.Class;
using airbnb.DAO;
using airbnb.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class CreerCompte : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            //Personne
            string nom = this.txtNom.Text;
            string prenom = this.txtPrenom.Text;
            string telephone = this.txtTel.Text;
            string login = this.txtLogin.Text;
            string password = this.txtPassword.Text;
            string email = this.txtEmail.Text;

            //Adresse
            string nomAdresse = this.txtNomAdresse.Text;
            string numero = this.txtNumero.Text;
            string voie = this.txtVoie.Text;
            string codePostal = this.txtCP.Text;
            string ville = this.txtVille.Text;

            DaoPersonne daoPersonne = new DaoPersonne();
            daoPersonne.CreateClient(nom, prenom, telephone, email, login, password, nomAdresse, numero, voie, codePostal, ville);

            Response.Redirect(Constant.PageConnexion);

        }
    }
}