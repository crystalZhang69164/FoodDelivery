<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="FoodDelivery.Customer" %>

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
    h1{
        text-align:center;
    }
    body{
        background-color:wheat;
    }
</style>
<body>
    <h1>Bird Dash</h1>
    <h2>Customer</h2>
    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a class="active" href="CustomerProfile.aspx">Profile</a></li>
        <li><a href="CustTransaction.aspx">Transaction</a></li>
        <li><a href="CustOrder.aspx">Your Orders</a></li>
        
        <li><a href="Customer.aspx">Home</a></li>
        
    </ul>

    <br />
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <div class="centerAlignment">
                  <asp:Label ID="lblSearch" runat="server" Text="Search for a Restaurant " Font-Size="30pt" Text-align="center"></asp:Label>

            </div>
            <br />
            <br />
            <div class ="centerAlignment">
                <asp:TextBox ID="txtSearch" runat="server" Width ="300px"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />

            </div>
            <br />
            <br />
            <br />
            <div class="centerAlignment">
                
                <asp:Label ID="lblRest" runat="server" Font-Size="30pt" Text="Restaurants"></asp:Label>
                
            </div>
            
            <br />
            <br />

            <div class="centerAlignment">

                <asp:GridView ID="gvRestList" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="gvRestList_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="ID" SortExpression="ID" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:ImageField DataImageUrlField="Image" HeaderText="Image" ControlStyle-Height ="100px" ControlStyle-Width="100px">
                    </asp:ImageField>
                    <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                    <asp:BoundField DataField="ZipCode" HeaderText="Zip Code" SortExpression="ZipCode" />
                    <asp:BoundField DataField="RestaurantType" HeaderText="Restaurant Type" SortExpression="RestaurantType" />
                    <asp:BoundField DataField="CuisineType" HeaderText="Cuisine Type" SortExpression="CuisineType" />
                    <asp:CommandField ButtonType="Button" HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            </div>
            
            
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
