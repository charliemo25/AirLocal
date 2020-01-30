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
    public partial class ListHebergements : BasePage
    {
        private List<Hebergement> hebergements;

        protected void Page_Load(object sender, EventArgs e)
        {

            //if (IsCrossPagePostBack)
            //{

            //}
            ////Permet de recuperer les valeurs de la page précedente
            //if(PreviousPage != null)
            //{
            //    //On récupère ce qui a été saisi dans les dropDownList
            //    DropDownList ddlDepartement = (DropDownList)PreviousPage.FindControl("ddlDepartement");
            //    DropDownList ddlTypeHebergement = (DropDownList)PreviousPage.FindControl("ddlTypeHebergement");

            //    //Si la ddlDepartement est différente de null et si la chaine de caractère est différente de vide ou null
            //    if(ddlDepartement != null && !string.IsNullOrEmpty(ddlDepartement.SelectedValue))
            //    {
            //        departement = ddlDepartement.SelectedValue;
            //    }

            //    if (ddlTypeHebergement != null && !string.IsNullOrEmpty(ddlTypeHebergement.SelectedValue))
            //    {
            //        typeHebergement= ddlTypeHebergement.SelectedValue;
            //    }
            //}

            string departement = Request["Departement"];
            string typeHebergement = Request["Type"];

            hebergements = loadHebergement(departement, typeHebergement);

            Session[Constant.LoadHebergement] = hebergements;

            if (!IsPostBack)
            {

                this.lvwHebergement.DataSource = hebergements;
                this.lvwHebergement.DataBind();

            }
        }

        private List<Hebergement> loadHebergement(string departement, string typeHebergement)
        {
            DaoHebergement daoHebergement = new DaoHebergement();
            return daoHebergement.GetHebergements(departement, typeHebergement);
        }

        protected void btnFavoris_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;

            if(user != null )
            {
                int id = Convert.ToInt32(arg);

                if(user.Favoris == null)
                {
                    user.Favoris = new List<Hebergement>();
                }

                var hebergement = user.Favoris.Where(x => x.IdHebergement == id);

                if (hebergement != null && hebergement.Count() == 0)
                {
                    Hebergement fav = hebergements.First(x => x.IdHebergement == id);

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

        protected void btnNom_Click(object sender, EventArgs e)
        {
            string url = Constant.PageDetailHebergement + "?Hebergement=" + ((LinkButton)sender).CommandArgument;
            Response.Redirect(url);
        }

        protected void btnReserver_Click(object sender, EventArgs e)
        {

            if (user != null)
            {
                
                string url = Constant.PageDetailHebergement + "?Hebergement=" + ((Button)sender).CommandArgument;
                Response.Redirect(url);

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }

    }
}