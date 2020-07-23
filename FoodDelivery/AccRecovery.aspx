<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AccRecovery.aspx.cs" Inherits="FoodDelivery.AccRecovery" %>

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
            width:10px;
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
    </style>
<head runat="server">
    <title>AccountRecovery</title>
</head>
    

<body>
    <h1>Account Recovery</h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Select the account type you would like to recover"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnCust" runat="server" Text="Customer" OnClick="btnCust_Click" />
            <div class="divider2"></div>
            <asp:Button ID="btnRest" runat="server" Text="Restaurant" OnClick="btnRest_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblRecoveryEmail" runat="server" Text="Please enter the email associated with the account" Visible="False"></asp:Label>
            <br />
            <asp:TextBox ID="txtRecoveryEmail" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblRecoveryPassword" runat="server" Text="Recovery Password" Visible="False"></asp:Label>
            <br />
            <br />

            
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <div class="divider2"></div>
            <asp:Button ID="btnGetPassword" runat="server" Text="Get Password" OnClick="btnGetPassword_Click" />


        </div>
    </form>
</body>
</html>
