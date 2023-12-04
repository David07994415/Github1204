using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Razor.Tokenizer;
using System.Web.UI;
using System.Web.UI.WebControls;
using test1109;

namespace _1113test1
{
    public partial class BackEnd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ShowDB();
            }


        }
        void ShowDB()
        {
            DBHelper helper = new DBHelper();
            string sql = "select * from Common ORDER BY CreateDate DESC";
            GridView1.DataSource = helper.SearchDb(sql);
            GridView1.DataBind();
            helper.CloseDb();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void EDD(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ShowDB();
        }
        //更新資料
        protected void UPP(object sender, GridViewUpdateEventArgs e)
        {
            // 取得資料表的 ID
            GridViewRow row = GridView1.Rows[e.RowIndex];   // 找到目前GirdView的編輯行數
            int bindId = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value); // 取得資料表的 ID

        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ShowDB();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                // 取得要刪除行的ID
                int deletedID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

                // 使用 ID 刪除資料
                DBHelper helper = new DBHelper();
                string deleteSql = "DELETE FROM Common WHERE ID = @ID";
                SqlParameter parameter = new SqlParameter("@ID", SqlDbType.Int) { Value = deletedID };
                helper.UpdateDb(deleteSql, new SqlParameter[] { parameter });
                helper.CloseDb();

                // 重新綁定 GridView 以顯示更新後的數據
                ShowDB();
            }
            catch (Exception ex)
            {
                // 處理例外狀況，你可以在這裡記錄錯誤或顯示使用者友好的錯誤訊息
                Response.Write($"刪除時發生錯誤：{ex.Message}");
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            ShowDB();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                // 取得資料表的 ID
                int updatedID = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);

                GridViewRow row = GridView1.Rows[e.RowIndex];

                // 名稱更新
                TextBox tb_title = row.FindControl("TextBox1") as TextBox;
                string updatedPoster = tb_title.Text;

                // 使用新值更新數據庫
                DBHelper helper = new DBHelper();
                string updateSql = "UPDATE Common SET Poster = @Poster WHERE ID = @ID";
                SqlParameter[] parameters = {
            new SqlParameter("@Poster", SqlDbType.NVarChar) { Value = updatedPoster },
            new SqlParameter("@ID", SqlDbType.Int) { Value = updatedID }
            // 根據需要為其他列添加其他參數...
        };

                helper.UpdateDb(updateSql, parameters);
                helper.CloseDb();

                // 重置 GridView 的編輯模式
                GridView1.EditIndex = -1;

                // 刷新 GridView 以顯示更新後的數據
                ShowDB();
            }
            catch (Exception ex)
            {
                // 處理例外狀況，你可以在這裡記錄錯誤或顯示使用者友好的錯誤訊息
                Response.Write($"更新時發生錯誤：{ex.Message}");
            }
        }
    }
}