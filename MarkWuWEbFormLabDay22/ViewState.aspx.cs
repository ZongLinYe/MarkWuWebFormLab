using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWEbFormLabDay22
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 第一次載入頁面時，檢查 ViewState 是否有保存名稱
         
            }
            if (ViewState["Name"] != null)
            {
                string name = ViewState["Name"].ToString();
                txtName.Text = name;
                lblMessage.Text = "歡迎回來，" + name + "！";
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            // 儲存使用者輸入的名稱到 ViewState 中
            ViewState["Name"] = txtName.Text;
            lblMessage.Text = "你好，" + txtName.Text + "！你的名稱已經被儲存。";
        }
    }
}