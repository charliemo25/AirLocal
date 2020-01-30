using airbnb.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Utilities
{
    public class BasePage: System.Web.UI.Page
    {
        public Personne user;

        private void Page_PreInit(object sender, EventArgs e)
        {

            user = (Personne)Session[Constant.UtilisateurSession];

        }
    }
}