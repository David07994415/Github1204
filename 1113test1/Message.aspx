<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Message.aspx.cs" Inherits="_1113test1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-F3w7mX95PdgyTmZZMECAngseQB83DfGTowi0iMjiWaeVhAn4FJkqJByhZMI3AhiU" crossorigin="anonymous">
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
    <div class="container mt-5">
        <h2 class="mb-4">發表文章</h2>

        <div class="mb-3">
            <asp:Label ID="Label_Title" runat="server" Text="標題" CssClass="form-label"></asp:Label>
             <asp:TextBox ID="TextBox_title" runat="server" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="mb-3">
            <asp:Label ID="Label_Poster" runat="server" Text="發文者" CssClass="form-label"></asp:Label>
  <asp:TextBox ID="TextBox_name" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mb-3">
           <asp:Label ID="Label_Content" runat="server" Text="內容" CssClass="form-label"></asp:Label>
  <asp:TextBox ID="TextBox_Cotent" runat="server" CssClass="form-control" TextMode="MultiLine"></asp:TextBox>
        </div>

        <div class="mb-3">
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="送出" CssClass="btn btn-primary" />
         <asp:Button ID="Button4" runat="server" Text="取消" CssClass="btn btn-secondary" />

        </div>

        <div class="mb-3">
            <asp:Button ID="Btn_lastpage" runat="server" Text="回上頁" CssClass="btn btn-info" />
            <asp:Button ID="Btn_backtop" runat="server" Text="最上面" CssClass="btn btn-warning" />
            
        </div>
    </div>
</form>
    <script src="https://cdn.jsdelivr.net/npm/@popperjs/core@2.10.1/dist/umd/popper.min.js" integrity="sha384-W8fXfP3gkOKtndU4JGtKDvXbO53Wy8SZCQHczT5FMiiqmQfUpWbYdTil/SxwZgAN" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.1/dist/js/bootstrap.min.js" integrity="sha384-skAcpIdS7UcVUC05LJ9Dxay8AXcDYfBJqt1CJ85S/CFujBsIzCIv+l9liuYLaMQ/" crossorigin="anonymous"></script>
</body>
</html>
