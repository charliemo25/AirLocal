using airbnb.Class;
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
    public partial class Reservations : UserLogged
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (user != null)
            {
                
                if (!IsPostBack)
                {
                    this.lvwReservations.DataSource = user.Reservations;
                    this.lvwReservations.DataBind();
                }

            }
            else
            {
                Response.Redirect(Constant.PageConnexion);
            }
        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.PagePaiement);
        }

        //Refaire la suppression de reservation
        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            string arg = ((Button)sender).CommandArgument;
            int id = Convert.ToInt32(arg);

            Reservation reservation= user.Reservations.First(x => x.IdReservation == id);

            DaoPersonne daoPersonne = new DaoPersonne();
            daoPersonne.DeleteReservation(user, reservation);
            Response.Redirect(Constant.PageReservations);
        }
    }
}