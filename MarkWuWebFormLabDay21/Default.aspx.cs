using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWebFormLabDay21
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Response.Redirect方法：");
            Response.Redirect("Detail.aspx");
            Response.Write("測試 Redirect");
        }
    }
}