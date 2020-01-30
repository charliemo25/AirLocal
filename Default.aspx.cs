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
    public partial class _Default : BasePage
    {
        public string departement { get { return this.ddlDepartement.SelectedValue; } }
        public string typeHebergement { get { return this.ddlTypeHebergement.SelectedValue; } }
        protected void Page_Load(object sender, EventArgs e)
        {
            DaoHebergement daoHebergement = new DaoHebergement();
            Session[Constant.LoadHebergement] = daoHebergement.GetHebergements("","");
        }

        
        //Formulaire
        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string departement = ddlDepartement.SelectedValue;
            string type = ddlTypeHebergement.SelectedValue;

            string url = Constant.PageListeHebergement + "?Departement=" + departement + "&Type="+type;
            
            Response.Redirect(url);
        }

        //Carousel
        protected void lbHebergement1_Click(object sender, EventArgs e)
        {
            
            string url = Constant.PageDetailHebergement + "?Hebergement=" + ((LinkButton)sender).CommandArgument;

            Response.Redirect(url);
        }
    }
}