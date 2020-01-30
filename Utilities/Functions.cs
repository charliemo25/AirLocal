using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace airbnb.Utilities
{
    public class Functions 
    {

        static Boolean IsConnected()
        {
            if (HttpContext.Current.Session["user"] != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}