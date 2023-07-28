using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWEbFormLabDay22
{
    public partial class Cookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["MyCookie"] != null)
            {
                Response.Write($"Cookie 的值為 {Request.Cookies["MyCookie"].Value}");
            }
            else
            {
                Response.Write("Cookie 不存在");
            }   
        }

        protected void BtnSetCookieClick(object sender, EventArgs e)
        {
            // 建立一個 Cookie 物件
            HttpCookie cookie = new HttpCookie("MyCookie");
            // 設定 Cookie 的值
            cookie.Value = "Mark Wu";
            // 設定 Cookie 的過期日
            cookie.Expires = DateTime.Now.AddDays(1);
            // 將 Cookie 加入到回應中
            Response.Cookies.Add(cookie);
            // 將 Cookie 的值顯示在網頁上
            Response.Write($"Cookie 的值為 {cookie.Value}");
        
        }
    }
}