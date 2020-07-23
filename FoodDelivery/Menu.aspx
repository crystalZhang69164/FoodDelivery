<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="FoodDelivery.Menu" %>

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
        .divider3{
            width:75px;
            height:auto;
            display:inline-block;
        }
        .leftMargin{
            width:150px;
            display:inline-block;
        }
        .centerMargin{
            text-align: center;
            margin-right: auto;
            margin-left: auto;
        }
        .centerAlignment{
            text-align:center;
        }
</style>
<body>
    <h1>Bird Dash</h1>
    
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


            <div class="centerMargin">
                  <asp:Label ID="lblRestMenu" runat="server" Text="Restaurant Menu" Font-Size="30pt" ></asp:Label>

            </div>
            <asp:Button ID="btnAddNewItem" runat="server" OnClick="btnAddNewItem_Click" Text="Add New Item" />
            <br />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Item Name:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Visible="False"></asp:TextBox>
            <div class="divider2"></div>
            <asp:Label ID="lblDescription" runat="server" Text="Description:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" Visible="False"></asp:TextBox>
            <div class="divider3"></div>
            <asp:Label ID="lblCategory" runat="server" Text="Category:" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server" Visible="False">
                 <asp:ListItem>Appetizers</asp:ListItem>
                <asp:ListItem>Entrees</asp:ListItem>
                <asp:ListItem>Desserts</asp:ListItem>
                <asp:ListItem>Beverages</asp:ListItem>
                <asp:ListItem>Alcohols</asp:ListItem>
                <asp:ListItem>Soups</asp:ListItem>
                <asp:ListItem>Sides</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblImage" runat="server" Text="Image" Visible="False"></asp:Label>
            <asp:FileUpload ID="fuFoodImage" runat="server" Visible="False" />
            <br />
            <br />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Visible="False" OnClick="btnCancel_Click" />
            <div class ="divider2"></div>
            <asp:Button ID="btnAdd" runat="server" Text="Add Item" Visible="False" OnClick="btnAdd_Click" />
            <br />
            <br />


            <br />
            <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSort" runat="server" Text="Sort By:" OnClick="btnSort_Click"/>
            <div class="divider2"></div>
            <asp:DropDownList ID="ddlSort" runat="server">
                <asp:ListItem>ASC</asp:ListItem>
                <asp:ListItem>DESC</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <div class="centerAlignment">

                <asp:GridView ID="gvMenu" runat="server" AutoGenerateColumns="False" OnRowEditing="gvMenu_RowEditing" OnRowUpdating="gvMenu_RowUpdating" OnRowCancelingEdit="gvMenu_RowCancelingEdit" OnRowDeleting="gvMenu_RowDeleting" style="margin-left: 0px">
                <Columns>
                    <asp:BoundField DataField="ItemId" HeaderText="ID" SortExpression="ItemID" ReadOnly ="true"/>
                    <asp:ImageField DataImageUrlField="ImageURL" HeaderText="Image" ControlStyle-Height="100px" ControlStyle-Width="100px">
<ControlStyle Height="100px" Width="100px"></ControlStyle>
                    </asp:ImageField>
                    
                    
                    <asp:BoundField DataField="Name" HeaderText="Item" SortExpression="Name" />
                    
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" DataFormatString="{0:c}" />
                    
                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                    <asp:CommandField ButtonType="Button" HeaderText="Edit" ShowEditButton="True" ShowHeader="True" />
                    <asp:CommandField ButtonType="Button" HeaderText="Delete" ShowDeleteButton="True" ShowHeader="True" />
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
        </div>


    </form>
</body>
</html>
