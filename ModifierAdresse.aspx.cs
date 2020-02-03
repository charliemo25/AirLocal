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
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session[Constant.idAdresse]);
            
            //var Adresse = user.Adresses.Where(x => x.IdAdresse == id);
            var Adresse = from x in user.Adresses
                          where x.IdAdresse == id
                          select x;

        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {

        }
    }
}