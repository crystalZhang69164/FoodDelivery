<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FoodDelivery.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        img{
            height:50px;
            width: 50px;
        }
        body{
            background-color:wheat;
        }
        .divider{
            width:30px;
            height:auto;
            display:inline-block;
        }
        .divider2{
            width:30px;
            height:auto;
            display:inline-block;
        }
        .leftMargin{
            width:150px;
            display:inline-block;
        }
        h1{
            text-align:center;
        }
        div{
            
            text-align:center;
        }
    </style>
    
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Login Page</h1>
        <div>
            <div>
                <asp:Label runat="server">Email</asp:Label>
                
            <asp:TextBox runat ="server" ID="txtEmail"></asp:TextBox>
                
            </div>
            
            
     
            <br />
            <div>
                <asp:Label runat="server">Password </asp:Label>
            <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
            </div>
            
            <br />
            <asp:LinkButton ID="linkbtnForgotPW" runat="server" OnClick="linkbtnForgotPW_Click">Forgot Password</asp:LinkButton>
            <br />



            
            <br />



            
            <br />



            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <div class="divider2"></div>
            <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />



        </div>
    </form>
</body>
</html>
