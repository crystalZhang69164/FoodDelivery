<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RestOrderList.aspx.cs" Inherits="FoodDelivery.RestOrderList" %>

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
    .centerAlignment{
        text-align: center;
    }

    .leftMargin {
        width: 150px;
        display: inline-block;
    }
</style>
<body>
    <h1>Bird Dash</h1>
    <h2>Orders</h2>

    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a class="active" href="RestaurantProfile.aspx">Profile</a></li>
        <li><a href="RestTransaction.aspx">Transaction</a></li>
        <li><a href="RestOrderList.aspx">Orders</a></li>
        <li><a href="Menu.aspx">Menu</a></li>
        <li><a href="Restaurant.aspx">Home</a></li>

    </ul>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Label ID="lblOrderHistory" runat="server" Font-Size="30pt" Text="Order History"></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="ddlStatus" runat="server">
                <asp:ListItem>Being Prepared</asp:ListItem>
                <asp:ListItem>Being Delivered</asp:ListItem>
                <asp:ListItem>Completed</asp:ListItem>
                <asp:ListItem>Problem Occurred</asp:ListItem>
            </asp:DropDownList>
            <div class="divider2"></div>
            <asp:Button ID="btnChangeStatus" runat="server" Text="Change Status" OnClick="btnChangeStatus_Click" />
            <br />
            <br />
            <div class="centerAlignment">
                <asp:GridView ID="gvOrderHistory" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="OrderId" HeaderText="Order ID" SortExpression="OrderId" />
                    <asp:BoundField DataField="custId" HeaderText="Customer ID" SortExpression="custId" />
                    <asp:BoundField DataField="Name" HeaderText="Item Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Qty" />
                    <asp:BoundField DataField="OrderTime" HeaderText="Order Time" SortExpression="OrderTime" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:TemplateField HeaderText="Change Status">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkComplete" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
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
        </div>
    </form>
</body>
</html>
