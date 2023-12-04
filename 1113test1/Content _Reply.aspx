<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Content_Reply.aspx.cs" Inherits="_1113test1.Content_Reply" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>回覆留言</title>
     <style>
        .truncate-50 {
            overflow: hidden;
            text-overflow: ellipsis;
            white-space: nowrap;
            max-width: 300px; /* Adjust the max-width as needed */
        }
    </style>
</head>
<body>
     <form id="form1" runat="server" class="container mt-5">
        <div class="mb-3">
            <asp:Button ID="Btn_Reply" runat="server" OnClick="Btn_reply_Click" Text="回覆文章" CssClass="btn btn-primary" />
        </div>

        <div class="mb-3">
            <table class="table" style="width: 800px;">
                <tbody>
                    <tr>
                        <th scope="row">主題</th>
                        <td><asp:Label ID="Label_Topic" runat="server" Text="Label" CssClass="text-primary"></asp:Label></td>
                    </tr>
                    <tr>
                        <th scope="row">發文者</th>
                        <td><asp:Label ID="Label_Poster" runat="server" Text="Label" CssClass="fw-bold"></asp:Label></td>
                    </tr>
                    <tr>
                         <th scope="row">內容</th>
                        <td>
                            <asp:Label ID="Label_Content" runat="server" Text="Long content goes here."></asp:Label>
                            <p class="truncate-50" id="truncateContent"></p>
                        </td>
                    </tr>
                    <tr>
                        <th scope="row">發文日期</th>
                        <td><asp:Label ID="Label_Datetime" runat="server" Text="Label"></asp:Label></td>
                    </tr>
                </tbody>
            </table>
            <br />
        </div>
           <div class="container mt-5">

      <div class="mb-3">

      </div>

      <div class="mb-3">
          <asp:Label ID="Label1" runat="server" Text="回覆者" CssClass="form-label"></asp:Label>
<asp:TextBox ID="TReply_name" runat="server" CssClass="form-control"></asp:TextBox>
      </div>



      <div class="mb-3">
         <asp:Label ID="Label2" runat="server" Text="內容" CssClass="form-label"></asp:Label>
<asp:TextBox ID="TReply_Cotent" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
      </div>

      <div class="mb-3">
           <asp:Button ID="Bottom011" runat="server" OnClick="Button11_Click01" Text="送出" CssClass="btn btn-primary" />
       <asp:Button ID="Button4" runat="server" Text="取消" CssClass="btn btn-secondary" />

      </div>

      <div class="mb-3">
          <asp:Button ID="Btn_lastpage" runat="server" Text="回上頁" CssClass="btn btn-info" />
          <asp:Button ID="Btn_backtop" runat="server" Text="最上面" CssClass="btn btn-warning" />
          
      </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>

</body>
</html>
