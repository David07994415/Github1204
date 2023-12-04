<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Forum.aspx.cs" Inherits="_1113test1.WebForm1" %>

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
           
            <asp:Button ID="Btn_01" runat="server" Text="發表留言" OnClick="Btn_01_Click" CssClass="btn btn-primary mt-3" />
           
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="table table-striped">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Content.aspx?id={0}" DataTextField="Theme" HeaderText="主題" />
                    <asp:BoundField DataField="Poster" HeaderText="發表人" SortExpression="Poster" />
                    <asp:BoundField DataField="CreateDate" HeaderText="發表日期" SortExpression="CreateDate" />
                    <asp:BoundField DataField="CreateDate" HeaderText="最後回覆" SortExpression="CreateDate" />
                    <asp:BoundField DataField="Reply" HeaderText="回應" SortExpression="Reply" />
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
            <asp:Button ID="Btn_Back" runat="server" Text="後端登入" CssClass="btn btn-primary mt-3" OnClick="Btn_Back_Click" />
        </div>
        
        <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js"></script>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"></script>
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
    </form>
</body>
</html>
