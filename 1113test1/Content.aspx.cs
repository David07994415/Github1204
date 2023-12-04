using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public partial class WebForm3 : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
{
            if (!IsPostBack)
            {
                // 檢查是否有ID參數
                if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
                {
                    // 嘗試進行轉換
                    if (int.TryParse(Request.QueryString["ID"], out int id))
                    {
                        // 使用ID檢索資料，並顯示在頁面上
                        // 這裡你需要根據實際情況來實現檢索和顯示的邏輯
                        DB(id);
                    }
                    else
                    {
                        // 處理轉換失敗的情況，例如顯示錯誤訊息或轉向到錯誤頁面
                        Response.Write("無效的 ID 參數");
                    }
                }
            }
        }

protected void Btn_reply_Click(object sender, EventArgs e)
  {
            // 檢查是否有ID參數
            if (!string.IsNullOrEmpty(Request.QueryString["ID"]))
            {
                // 嘗試進行轉換
                if (int.TryParse(Request.QueryString["ID"], out int id))
                {
                    // 使用ID檢索資料，並顯示在頁面上
                    // 這裡你需要根據實際情況來實現檢索和顯示的邏輯
                    // 將 ID 存入 Session
                    Session["CurrentPageID"] = id;

                    // 將使用者導向到 Login_Reply.aspx
                    Response.Redirect("Login_Reply.aspx");
                }
                else
                {
                    // 處理轉換失敗的情況，例如顯示錯誤訊息或轉向到錯誤頁面
                    Response.Write("無效的 ID 參數");
                }
            }
        }
    
private void DB(int id)
{
    // 假設 connStr 是你的資料庫連接字串
    string connStr = "OliverDB";

    using (SqlConnection connection = new SqlConnection(WebConfigurationManager.ConnectionStrings["OliverDB"].ConnectionString))
    {
        connection.Open();

        // 使用參數化查詢以避免 SQL 注入攻擊
        string query = "SELECT * FROM Common WHERE ID = @ID";
        using (SqlCommand command = new SqlCommand(query, connection))
        {
            command.Parameters.AddWithValue("@ID", id);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    // 將資料填充到頁面上的控制項
                    Label_Topic.Text = reader["Theme"].ToString();
                    Label_Poster.Text = reader["Poster"].ToString();
                    Label_Content.Text = reader["Comment"].ToString();
                    Label_Datetime.Text = reader["CreateDate"].ToString();
                    // 其他欄位以此類推
                }
                else
                {
                    // 沒有找到相應的資料
                    // 你可能想要顯示一個錯誤訊息或者轉向到一個錯誤頁面
                }
            }
        }
    }
}
    }
}
