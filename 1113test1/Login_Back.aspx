<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Back.aspx.cs" Inherits="_1113test1.Login_Back" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
     
        </div>
        
        </div>
    </div>
 
        <body class="bg-light">

    <div class="container">
        <div class="row justify-content-center mt-5">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title text-center">後台管理登入頁面Login</h5>

                        <!-- 登入表單 -->
                        <form id="form1" runat="server">
                            <!-- 帳號輸入欄位 -->
                            <div class="mb-3">
                               <label for="username" class="form-label">帳號Username</label>
                                <asp:TextBox runat="server" class="form-control" id="txtUsername01" placeholder="Enter your username"></asp:TextBox>
                            </div>

                            <!-- 密碼輸入欄位 -->
                            <div class="mb-3">
                                <label for="password" class="form-label">密碼Password</label>
                                <asp:TextBox runat="server" class="form-control" id="txtPassword01" placeholder="Enter your password"></asp:TextBox>
                            </div>

                            <!-- 送出按鈕 -->
                            <button type="submit" class="btn btn-primary w-100" id="btnLogin">登入 Login</button>
                        </form>

                        <!-- 回上頁按鈕 -->
                        <div class="mt-3 text-center">
                            <a href="Forum.aspx" class="btn btn-link" id="Btn_Back">上一頁 Back </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    </div>
</div>
        </div>
          
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
