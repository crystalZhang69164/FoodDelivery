<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustTransaction.aspx.cs" Inherits="FoodDelivery.Transaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
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
        width: 40%;
        display: inline-block;
    }
    .centerAlignment{
        text-align:center;
    }
    h1, h2{
        text-align:center;
    }
    body{
        background-color:wheat;
    }
</style>
<body>
    <h1>Bird Dash</h1>
    
    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a class="active" href="CustomerProfile.aspx">Profile</a></li>
        <li><a href="CustTransaction.aspx">Transaction</a></li>
        <li><a href="CustOrder.aspx">Your Orders</a></li>
        
        <li><a href="Customer.aspx">Home</a></li>
        
    </ul>

    <br />
    <h2>Transaction</h2>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:GridView ID="gvTransaction" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="CustomerWalletId" HeaderText="Customer ID" SortExpression="WalletID" />
                    <asp:BoundField DataField="CardType" HeaderText="Payment Type" SortExpression="CardType" />
                    <asp:BoundField DataField="RestaurantWalletId" HeaderText="RestaurantID" SortExpression="RestaurantWalletId" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" SortExpression="Amount" />
                    <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="lblFund" runat="server" Text="Enter Amount to Fund into Acc:"></asp:Label>
            <asp:TextBox ID="txtFund" runat="server"></asp:TextBox>
            <div class="divider2">
                    <asp:Button ID="btnFund" runat="server" OnClick="Button1_Click" Text="Fund Acc" />

            </div>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
