﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1113test1
{
    public partial class Login_Back : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 檢查是否是 PostBack
            if (IsPostBack)
            {
                string username = txtUsername01.Text;
                string password = txtPassword01.Text;

                // 進行帳號密碼驗證

                if (username == "admin" && password == "admin")//帳號密碼
                    {

                        Response.Write("<script>alert('登入成功')</script>");
                        Session["iduesrname"] = username;
                        Response.Redirect("BackEnd.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('帳號或密碼錯誤')</script>");
                    }

                }
            }
       

    }
    
}
