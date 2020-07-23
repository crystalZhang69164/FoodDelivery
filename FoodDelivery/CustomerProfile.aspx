<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerProfile.aspx.cs" Inherits="FoodDelivery.CustomerProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
    h1 {
        text-align: center;
    }

    body {
        background-color: #a2fff2;
    }

    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
        background-color: #333;
    }

    li {
        float: right;
    }

    li a {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

    li a:hover {
            background-color: #111;
        }

    body {
        background-color: wheat;
    }

    .divider {
        width: 10px;
        height: auto;
        display: inline-block;
    }

    .divider2 {
        width: 30px;
        height: auto;
        display: inline-block;
    }

    .leftMargin {
        width: 150px;
        display: inline-block;
    }
</style>
<body>
    <h1>Bird Dash</h1>
    <h2>Customer Profile</h2>

    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a href="CustomerProfile.aspx">Profile</a></li>
        <li><a href="CustTransaction.aspx">Transaction</a></li>
        <li><a href="CustOrder.aspx">Your Orders</a></li>
        
        <li><a href="Customer.aspx">Home</a></li>

    </ul>

    <form id="form1" runat="server">
        <div>
            <br />

            <asp:Button ID="btnEdit" runat="server" Text="Edit Info" OnClick="btnEdit_Click" />
            <div class =" divider2"></div>
            <asp:Button ID="btnChangePw" runat="server" Text="Change Password" OnClick="btnChangePw_Click" />

            <br />
            <br />
             <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" ReadOnly="True"></asp:TextBox>


            <asp:Label ID="lblNewPassword" runat="server" Text="New Password:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtNewPassword" runat="server" Visible="False"></asp:TextBox>


            <br />
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address:"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:Button ID="btnPwCancel" runat="server" Text="Cancel" Visible="False" OnClick="btnPwCancel_Click" />
            <div class=" divider2"></div>
            <asp:Button ID="btnUpdatePw" runat="server" Text="Update Password" Visible="False" OnClick="btnUpdatePw_Click" />
            <br />
            <br />
            <asp:Label ID="lblCity" runat="server" Text="City:"></asp:Label>
            <asp:TextBox ID="txtCity" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblState" runat="server" Text="State:"></asp:Label>
            <asp:TextBox ID="txtState" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="ddlState" runat="server" Visible="False">
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AK</asp:ListItem>
                <asp:ListItem>AZ</asp:ListItem>
                <asp:ListItem>AR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
                <asp:ListItem>CO</asp:ListItem>
                <asp:ListItem>CT</asp:ListItem>
                <asp:ListItem>DE</asp:ListItem>
                <asp:ListItem>FL</asp:ListItem>
                <asp:ListItem>GA</asp:ListItem>
                <asp:ListItem>HI</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>IL</asp:ListItem>
                <asp:ListItem>IN</asp:ListItem>
                <asp:ListItem>IA</asp:ListItem>
                <asp:ListItem>KS</asp:ListItem>
                <asp:ListItem>KY</asp:ListItem>
                <asp:ListItem>LA</asp:ListItem>
                <asp:ListItem>ME</asp:ListItem>
                <asp:ListItem>MD</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MI</asp:ListItem>
                <asp:ListItem>MN</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MO</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>NE</asp:ListItem>
                <asp:ListItem>NV</asp:ListItem>
                <asp:ListItem>NH</asp:ListItem>
                <asp:ListItem>NJ</asp:ListItem>
                <asp:ListItem>NM</asp:ListItem>
                <asp:ListItem>NY</asp:ListItem>
                <asp:ListItem>NC</asp:ListItem>
                <asp:ListItem>ND</asp:ListItem>
                <asp:ListItem>OH</asp:ListItem>
                <asp:ListItem>OK</asp:ListItem>
                <asp:ListItem>OR</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>RI</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SD</asp:ListItem>
                <asp:ListItem>TN</asp:ListItem>
                <asp:ListItem>TX</asp:ListItem>
                <asp:ListItem>UT</asp:ListItem>
                <asp:ListItem>VT</asp:ListItem>
                <asp:ListItem>VA</asp:ListItem>
                <asp:ListItem>WA</asp:ListItem>
                <asp:ListItem>WV</asp:ListItem>
                <asp:ListItem>WI</asp:ListItem>
                <asp:ListItem>WY</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblZip" runat="server" Text="Zip Code:"></asp:Label>
            <asp:TextBox ID="txtZip" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblBillingAddress" runat="server" Text="Billing Address:"></asp:Label>
            <asp:TextBox ID="txtBillingAddress" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblBillingCity" runat="server" Text="Billing City:"></asp:Label>
            <asp:TextBox ID="txtBillingCity" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblBillingState" runat="server" Text="Billing State:"></asp:Label>
            <asp:TextBox ID="txtBillingState" runat="server" ReadOnly="True"></asp:TextBox>
            <asp:DropDownList ID="ddlBillingState" runat="server" Visible="False">
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AK</asp:ListItem>
                <asp:ListItem>AZ</asp:ListItem>
                <asp:ListItem>AR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
                <asp:ListItem>CO</asp:ListItem>
                <asp:ListItem>CT</asp:ListItem>
                <asp:ListItem>DE</asp:ListItem>
                <asp:ListItem>FL</asp:ListItem>
                <asp:ListItem>GA</asp:ListItem>
                <asp:ListItem>HI</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>IL</asp:ListItem>
                <asp:ListItem>IN</asp:ListItem>
                <asp:ListItem>IA</asp:ListItem>
                <asp:ListItem>KS</asp:ListItem>
                <asp:ListItem>KY</asp:ListItem>
                <asp:ListItem>LA</asp:ListItem>
                <asp:ListItem>ME</asp:ListItem>
                <asp:ListItem>MD</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MI</asp:ListItem>
                <asp:ListItem>MN</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MO</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>NE</asp:ListItem>
                <asp:ListItem>NV</asp:ListItem>
                <asp:ListItem>NH</asp:ListItem>
                <asp:ListItem>NJ</asp:ListItem>
                <asp:ListItem>NM</asp:ListItem>
                <asp:ListItem>NY</asp:ListItem>
                <asp:ListItem>NC</asp:ListItem>
                <asp:ListItem>ND</asp:ListItem>
                <asp:ListItem>OH</asp:ListItem>
                <asp:ListItem>OK</asp:ListItem>
                <asp:ListItem>OR</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>RI</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SD</asp:ListItem>
                <asp:ListItem>TN</asp:ListItem>
                <asp:ListItem>TX</asp:ListItem>
                <asp:ListItem>UT</asp:ListItem>
                <asp:ListItem>VT</asp:ListItem>
                <asp:ListItem>VA</asp:ListItem>
                <asp:ListItem>WA</asp:ListItem>
                <asp:ListItem>WV</asp:ListItem>
                <asp:ListItem>WI</asp:ListItem>
                <asp:ListItem>WY</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblBillingZipCode" runat="server" Text="Billing Zip Code:"></asp:Label>
            <asp:TextBox ID="txtBillingZipCode" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Visible="False" OnClick="btnCancel_Click" />
            <div class="divider2"></div>
            <asp:Button ID="btnUpdateInfo" runat="server" Text="Update Info" Visible="False" OnClick="btnUpdateInfo_Click" />
            <br />
            <br />


        </div>
    </form>
</body>
</html>
