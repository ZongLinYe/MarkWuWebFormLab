using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWEbFormLabDay22
{
    public partial class PageCache : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 模擬從資料庫或其他來源讀取資料
                List<string> dataList = new List<string>{"資料1", "資料2", "資料3", "資料4", "資料5" };
                // 將資料快取到 Page.Cache 中，有效期限為 10 分鐘
                Cache.Insert("DataListCache", dataList, null, DateTime.UtcNow.AddMinutes(10), TimeSpan.Zero);
            }
        }

        protected void BtnGetDataClick(object sender, EventArgs e)
        {
            if (Cache["DataListCache"] != null)
            {
                // DataSource 和 DataBind() 是在 ASP.NET Web Forms 中用於綁定資料到資料控制項（例如 GridView、DropDownList、Repeater 等）的關鍵方法。

                //DataSource:
                //DataSource 是一個屬性，它是資料控制項用於存放要顯示或編輯的資料的物件。通常，DataSource 屬性可以是各種資料來源，例如 DataSet、DataTable、List、LINQ 查詢等。當你想要將資料顯示在資料控制項上時，首先要將資料指定給該資料控制項的 DataSource 屬性。

                //DataBind():
                //DataBind() 是一個方法，用於將資料控制項與 DataSource 綁定，使其顯示資料。當你設置完資料控制項的 DataSource 屬性後，需要呼叫 DataBind() 方法，以便資料控制項能夠將 DataSource 中的資料顯示出來。
                GridView1.DataSource = Cache["DataListCache"];
                GridView1.DataBind();
            }
            else
            {
                // 產生一個 List<string> 物件
                List<string> data = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    data.Add($"第 {i} 筆資料");
                }
                // 將 data 物件存入 Cache 中
                Cache["DataListCache"] = data;
                // 將 data 物件指定給 DataList1 的 DataSource 屬性
                GridView1.DataSource = data;
                // 將 data 物件指定給 DataList1 的 DataSource 屬性
                GridView1.DataBind();
            }
        }
    }
}