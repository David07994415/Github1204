using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1113test1
{
    public partial class Login_Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 檢查是否是 PostBack
            if (IsPostBack)
            {
                string username = txtUsername01.Text;
                string password = txtPassword01.Text;

                // 進行帳號密碼驗證
                if (username == "admin" && password == "admin")
                {
                    if (Session["CurrentPageID"] != null)
                    {
                        // 如果包含，取得 ID 並進行相應的處理
                        int currentPageID = (int)Session["CurrentPageID"];
                        Response.Write("<script>alert('登入成功')</script>");
                    Response.Redirect($"Content _Reply.aspx?id={currentPageID}");
                    }
                }
                else
                {
                    Response.Write("<script>alert('帳號或密碼錯誤')</script>");
                }
            }
        }
    }

}
