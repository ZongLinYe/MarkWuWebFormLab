using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWEbFormLabDay22
{
    public partial class Session : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserId"] != null)
            {
                Response.Write($"Session[\"UserId\"] = {Session["UserId"]}");
            }
        }

        protected void BtnSetSessionClick(object sender, EventArgs e)
        {
            Session["UserId"] = 111;
        }
    }
}