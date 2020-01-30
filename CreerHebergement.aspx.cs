using airbnb.Class;
using airbnb.DAO;
using airbnb.Entities;
using airbnb.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace airbnb
{
    public partial class CreerHebergement : UserLogged
    {
        List<Hebergement> hebergements;
        Hebergement hebergement;
        protected void Page_Load(object sender, EventArgs e)
        {
            hebergements = (List<Hebergement>)Session[Constant.LoadHebergement];
            
            if(user != null)
            {

            }
            else
            {
                Response.Redirect("Connexion.aspx");
            }

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            Adresse adresse = new Adresse();
            hebergement = new Hebergement();

            //hebergement
            hebergement.Nom = txtNom.Text;
            hebergement.Type = ddlType.SelectedValue;
            hebergement.Description = txtDescription.Text;
            hebergement.Prix = Convert.ToDecimal(txtPrix.Text);

            //Photo
            string folderPath = Server.MapPath("/images/");
            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }


            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            hebergement.Photo = FileUpload1.FileName;
            //hebergement.adresse
            adresse.NomAdresse = txtNomAdresse.Text;
            adresse.Numero = txtNumeroAdresse.Text;
            adresse.Voie = txtVoie.Text;
            adresse.CodePostal = txtCP.Text;
            adresse.Ville = txtVille.Text;

            DaoHebergement daoHebergement = new DaoHebergement();
            bool result = daoHebergement.AddHebergement(hebergements,hebergement, adresse, user);

            if (!result)
            {
                Response.Redirect("default.aspx");
            }
        }
    }
}