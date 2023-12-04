<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BackEnd.aspx.cs" Inherits="_1113test1.BackEnd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server">
        <div class="container mt-4">
           <h5 style="font-size: 40px; color: #33CCCC; font-weight: bolder;">後台登入管理頁面</h5>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-striped" OnRowEditing="EDD" OnRowUpdating="GridView1_RowUpdating">
                <AlternatingRowStyle BackColor="White" />
                 <Columns>
        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
        <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Content.aspx?id={0}" DataTextField="Theme" HeaderText="主題" />
        <asp:TemplateField HeaderText="發表人">
            <ItemTemplate>
                <asp:Label ID="Label_Poster" runat="server" Text='<%# Bind("Poster") %>'></asp:Label>
            </ItemTemplate>
            <EditItemTemplate>
                <asp:TextBox ID="TextBox_Poster" runat="server" Text='<%# Bind("Poster") %>'></asp:TextBox>
            </EditItemTemplate>
        </asp:TemplateField>
        <asp:BoundField DataField="CreateDate" HeaderText="發表日期" SortExpression="CreateDate" />
        <asp:BoundField DataField="CreateDate" HeaderText="最後回覆" SortExpression="CreateDate" />
        <asp:BoundField DataField="Reply" HeaderText="回應" SortExpression="Reply" />
        <asp:CommandField ShowEditButton="True" />
        <asp:CommandField ShowDeleteButton="True" />
    </Columns>
                <FooterStyle BackColor="#009699" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#009699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </div>
        
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
