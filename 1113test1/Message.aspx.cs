using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;

namespace _1113test1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["iduesrname"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                Response.Write("登入成功");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)     // TC：Button1語意不明顯，建議修正
        {                                                                                                // TC：沒有用到DBHelper物件，建議可以嘗試使用
            string connectionString = ConfigurationManager.ConnectionStrings["OliverDB"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            {
                string insertQuery = "INSERT INTO Common (Theme,Poster,Comment) VALUES (@Theme,@Poster, @Comment)";

                SqlCommand command = new SqlCommand(insertQuery, connection);
                {
                    command.Parameters.AddWithValue("@Poster", TextBox_name.Text);
                    command.Parameters.AddWithValue("@Theme", TextBox_title.Text);
                    command.Parameters.AddWithValue("@Comment", TextBox_Cotent.Text);
      
                   
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Response.Write("<script>alert('留言成功')</script>");
                            Response.Redirect("Forum.aspx");
                        }
                        else
                        {
                            // 使用 JavaScript 顯示失敗訊息
                            Response.Write("<script>alert('留言失敗')</script>");
                        }
                   
                    
                }
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }

        protected void Btn_send_Click(object sender, EventArgs e)
        {

        }
    }
}