using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Reflection.Emit;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1109;

namespace _1113test1
{
    public partial class Content_Reply : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if there is an ID parameter in the query string
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    // Try to convert
                    if (int.TryParse(Request.QueryString["ID"], out int id))
                    {
                        // Use ID to retrieve data and display on the page
                        DB(id);
                    }
                    else
                    {
                        // Handle conversion failure, e.g., display an error message or redirect to an error page
                        Response.Write("無效的 ID 參數");
                    }
                }
                else
                {
                    // Check if there is a userID in the Session
                    if (Session["userID"] != null)
                    {
                        // If userID is found in the Session, use it to retrieve data and display on the page
                        int userID = (int)Session["userID"];
                        DB(userID);
                    }
                    else
                    {
                        // Handle the case when neither ID nor userID is present
                        Response.Write("無效的 ID 參數");
                    }
                }
            }
        }

        protected void Btn_reply_Click(object sender, EventArgs e)
        {
            // Handle the reply button click logic
            // You can call the appropriate method or perform other processing
        }

        private void DB(int id)
        {
            // Assume connStr is your database connection string
            string connStr = "OliverDB";

            using (SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings[connStr].ConnectionString))
            {
                connection.Open();

                // Use parameterized query to prevent SQL injection attacks
                string query = "SELECT * FROM Common WHERE ID = @ID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate data into page controls
                            Label_Topic.Text = reader["Theme"].ToString();
                            Label_Poster.Text = reader["Poster"].ToString();
                            Label_Content.Text = reader["Comment"].ToString();
                            Label_Datetime.Text = reader["CreateDate"].ToString();
                            // Additional fields can be populated similarly
                        }
                        else
                        {
                            // No corresponding data found
                            // You might want to display an error message or redirect to an error page
                        }
                    }
                }
            }
        }

        protected void Button11_Click01(object sender, EventArgs e)
        {
            // Assume connStr is your database connection string
            string connStr = "OliverDB";

            using (SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings[connStr].ConnectionString))
            {
                string insertQuery = "INSERT INTO Reply (UserName, ReplyContent) VALUES (@UserName, @ReplyContent)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@UserName", TReply_name.Text);
                    command.Parameters.AddWithValue("@ReplyContent", TReply_Cotent.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Response.Write("<script>alert('留言成功')</script>");
                        Response.Redirect("Forum.aspx");
                    }
                    else
                    {
                        // Use JavaScript to display a failure message
                        Response.Write("<script>alert('留言失敗')</script>");
                    }
                }
            }
        }
    }
}