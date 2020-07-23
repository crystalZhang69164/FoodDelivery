<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Restaurant.aspx.cs" Inherits="FoodDelivery.Restaurant" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    h1 {
        text-align: center;
    }

    ul {
        list-style-type: none;
        margin: 0;
        padding: 0;
        overflow: hidden;
        background-color: #333;
    }
    .centerAlignment{
        text-align:center;
    }
    body{
        background-color:wheat;
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

</style>
<body>
    <h1>Bird Dash</h1>
    <h2>Restaurant</h2>
    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a href="RestaurantProfile.aspx">Profile</a></li>
        <li><a href="RestTransaction.aspx">Transaction</a></li>
        <li><a href="RestOrderList.aspx">Orders</a></li>
        <li><a href="Menu.aspx">Menu</a></li>
        <li><a href="Restaurant.aspx">Home</a></li>
        

    </ul>

    <br />
    <form id="form1" runat="server">
        <div>
            <h1>Welcome to Bird Dash</h1>
            
            <br />
            <br />
            <br />
            <div class="centerAlignment">
                <asp:Button ID="btnOrders" runat="server" Text="View Orders" OnClick="btnOrders_Click" />
            </div>
            
            <br />
            <br />
            <div class="centerAlignment">
                <asp:Button ID="btnMenu" runat="server" Text="Create A Menu" OnClick="btnMenu_Click" />
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
            <br />
            <br />
        </div>
    </form>
</body>
</html>
