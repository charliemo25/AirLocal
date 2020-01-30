using airbnb.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Utilities
{
    public class UserLogged : BasePage
    {
        private void Page_Init(object sender, EventArgs e)
        {
       
            if (user == null)
            {
                Response.Redirect(Constant.PageConnexion);
            }

        }
    }


}