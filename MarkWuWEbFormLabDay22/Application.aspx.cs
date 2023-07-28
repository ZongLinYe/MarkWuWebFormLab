using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarkWuWEbFormLabDay22
{
    public partial class Application : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 在頁面上顯示 AppCounter 變數的值
            // Application.Lock() 是一個方法，用於將應用程式層級變數鎖定，以防止多個使用者或請求同時訪問和修改這些變數。
            // 當你使用 Application.Lock() 時，其他請求將會等待，直到當前請求執行完畢並釋放鎖定為止。
            // 這麼做是為了確保在多執行緒環境下，對於共享的 Application 變數進行修改時不會發生衝突。
            Application.Lock();
            Application["AppCounter"] = (int)Application["AppCounter"] + 1;
            // Application.UnLock() 是用於解除應用程式層級變數鎖定的方法。
            // 一旦你完成對 Application 變數的修改，應該使用 Application.UnLock() 來解除鎖定，以便其他請求可以繼續訪問和修改 Application 變數。
            Application.UnLock();
            // 重要提示：在使用 Application.Lock() 和 Application.UnLock() 時要小心，
            // 確保在鎖定期間的操作盡量簡潔迅速，避免長時間鎖定 Application 導致其他請求長時間等待。
            // 因為鎖定時間過長可能會影響應用程式的性能和擴展性。
            // 如果可能，優先考慮使用更輕量級的同步方式或資料庫來處理共享資料的同步和存儲需求。


            // 在頁面上顯示 AppCounter 變數的值
            applicationCount.InnerText = $"這個頁面被呼叫次數 {Application["AppCounter"]}";

        }
    }
}