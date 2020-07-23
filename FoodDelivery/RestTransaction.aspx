<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestTransaction.aspx.cs" Inherits="FoodDelivery.RestTransaction" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<style>
    h1, h2 {
        text-align: center;
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
        body{
        background-color:wheat;
    }
</style>
<body>
    <h1>Bird Dash</h1>
    <h2>Transaction</h2>
    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a class="active" href="RestaurantProfile.aspx">Profile</a></li>
        <li><a href="RestTransaction.aspx">Transaction</a></li>
        <li><a href="RestOrderList.aspx">Orders</a></li>
        <li><a href="Menu.aspx">Menu</a></li>
        <li><a href="Restaurant.aspx">Home</a></li>


    </ul>

    <br />
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
