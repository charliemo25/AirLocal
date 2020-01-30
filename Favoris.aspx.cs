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
    public partial class Favoris : UserLogged
    {
        List<Hebergement> hebergements;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            hebergements = (List<Hebergement>)Session[Constant.LoadHebergement];

            if (user != null)
            {
                

                if (!IsPostBack)
                {
                    this.lvwFavoris.DataSource = user.Favoris;
                    this.lvwFavoris.DataBind();
                }

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }

        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int id = Convert.ToInt32(arg);
            Hebergement hebergement = user.Favoris.Single(x => x.IdHebergement == id);

            DaoPersonne daoPersonne = new DaoPersonne();
            daoPersonne.DeleteFavoris(user, hebergement);
            Response.Redirect(Constant.PageFavoris);

        }

        protected void btnReserver_Click(object sender, EventArgs e)
        {

            string url = Constant.PageDetailHebergement + "?Hebergement=" + ((Button)sender).CommandArgument;
            Response.Redirect(url);

        }
    }
}