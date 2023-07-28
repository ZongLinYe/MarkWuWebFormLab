using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;

namespace MarkWuWebFormLabDay1
{
    public partial class JsonData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string content = GetJsonContent("https://www.ktec.gov.tw/ktec_api.php?type=json");
            JsonDataDto dto = JsonConvert.DeserializeObject<JsonDataDto>(content);
            // 設定 JsonData.aspx 的 <span id="message" runat="server"></span>
            // 控制項的 InnerHtml 屬性可以用來設定 HTML 元素的內容
            message.InnerHtml += "<CAPTION><h1>高雄市政府相關求才資訊發佈</h1></CAPTION>  ";
            message.InnerHtml += "<table><TR><TH>類型</TH><TH>主題</TH><TH>發表日期</TH></TR>";
            int i = 0;
            foreach (var item in dto.entries)
            {
                if (item.title.Length > 35)
                {
                    item.title = item.title.Substring(0, 35);
                    item.title += "...<詳情請點>";
                    message.InnerHtml += "<tr>" + "<td>" + item.category + "</td>" +
                                         "<td><a href=\"detail.aspx?i=" + i + "\">" + item.title +
                                         "</a></td>" + "<td>" + item.publication_date + "</td></tr>";
                    i++;
                }
                else
                {
                    message.InnerHtml += "<tr>" + "<td>" + item.category + "</td>" +
                                         "<td><a href=\"detail.aspx?i=" + i + "\">" + item.title +
                                         "</a></td>" + "<td>" + item.publication_date + "</td></tr>";
                    i++;
                }
            }
            message.InnerHtml += "</table>";
        }

        private string GetJsonContent(string url)
        {
            string targetURI = url;

            // 建立連線前，先設定安全性通訊協定為 TLS 1.2
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var request = System.Net.WebRequest.Create(targetURI);
            request.ContentType = "application/json; charset=utf-8";
          
            var response = request.GetResponse();
            string text;
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }
    }
}