using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Razor.Tokenizer;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1109;

namespace _1113test1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {               ShowDB();

        }
        void ShowDB()
        {
            DBHelper helper = new DBHelper();
            string sql = "select * from Common ORDER BY CreateDate DESC";
            GridView1.DataSource = helper.SearchDb(sql);
            GridView1.DataBind();
            helper.CloseDb();

        }
        
        protected void Btn_01_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Btn_Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login_Back.aspx");
        }
    }
}