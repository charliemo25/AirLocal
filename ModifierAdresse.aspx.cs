using airbnb.DAO;
using airbnb.Entities;
using airbnb.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class ModifierAdresse : UserLogged
    {
        Adresse adresse;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session[Constant.idAdresse]);

            if (id == 0)
            {
                Response.Redirect(Constant.PageMesAdresses);
            }

            var Adresse = user.Adresses.First(x => x.IdAdresse == id);
            adresse = Adresse;

            if (!IsPostBack)
            {
                //Assigner les valeurs au formulaire
                txtNomAdresse.Text = Adresse.NomAdresse;
                txtNumero.Text = Adresse.Numero;
                txtVoie.Text = Adresse.Voie;
                txtCP.Text = Adresse.CodePostal;
                txtVille.Text = Adresse.Ville;
            }
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            adresse.NomAdresse = txtNomAdresse.Text;
            adresse.Numero = txtNumero.Text;
            adresse.Voie = txtVoie.Text;
            adresse.CodePostal = txtCP.Text;
            adresse.Ville = txtVille.Text;

            new DaoPersonne().UpdateAdresse(adresse);
            Response.Redirect(Constant.PageMesAdresses);
        }
    }
}