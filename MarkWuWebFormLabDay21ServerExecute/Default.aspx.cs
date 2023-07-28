using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWebFormLabDay21ServerExecute
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(".Execute方法：");//在不變更URL下，將頁面轉至同伺服器底下的其他網頁，執行完畢後將回到原本.aspx "繼續執行"
            Server.Execute("Detail.aspx");// detail.aspx 這頁面內容為 this message is in detail.aspx
            Response.Write("測試 Execute");
        }
    }
}