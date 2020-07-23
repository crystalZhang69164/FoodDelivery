<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderNow.aspx.cs" Inherits="FoodDelivery.OrderNow" %>

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
       .auto-style1 {
           width: 85px;
       }
       body{
           background-color:wheat;
       }
   </style>
<body>
    <h1>Bird Dash</h1>
    <h2>Order Now</h2>
    <ul>
        <li><a href="Login.aspx">Logout</a></li>
        <li><a class="active" href="CustomerProfile.aspx">Profile</a></li>
        <li><a href="Transaction.aspx">Transactions</a></li>
        <li><a href="CustOrder.aspx">Your Orders</a></li>
        <li><a href="OrderNow.aspx">Order Now</a></li>
        <li><a href="Customer.aspx">Home</a></li>
        
    </ul>

    <br />
    <form id="form1" runat="server">
        <div>

            <div class="centerAlignment">
                 <asp:Label ID="lblOrderList" runat="server" Font-Size="25pt" Text="OrderList"></asp:Label>

            </div>
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear List" />
            <div class="divider2"></div>
            <asp:Button ID="btnPlaceOrder" runat="server" Text="Place Order Now" OnClick="btnPlaceOrder_Click" />
            
            <br />
            <div class="centerAlignment">
                <asp:GridView ID="gvOrderOutput" runat="server" AutoGenerateColumns="False" OnRowDeleting="gvOrderOutput_RowDeleting">
                <Columns>
                    <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkRemove" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:ImageField DataImageUrlField="ImageURL" HeaderText="Image">
                    </asp:ImageField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" DataFormatString="{0:c}" />
                    <asp:BoundField DataField="Qty" HeaderText="Quantity" SortExpression="Quantity" />
                    <asp:CommandField ButtonType="Button" HeaderText="Remove" ShowDeleteButton="True" ShowHeader="True"  />
                
                </Columns>
            </asp:GridView>
            </div>
            
            
            <br />
            <table>
                <tr>
                    <th>Item Name</th>
                    <th>Description</th>
                    <th class="auto-style1">Price</th>
                    <th>Category</th>
                    <th>Quantity</th>
                    <th>Remove Item</th>
                    
                </tr>
                <asp:Repeater ID="rptOrderOutput" runat="server" Visible="true" OnItemCommand="rptOrderOutput_RemoveCommand">
                <ItemTemplate>
                    <tr>
                        <td>
                            <asp:Label ID="lblName" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Name") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblDescription" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblPrice" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Price", "{0:c}") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblCategory" runat="server" Text='<%# Bind("Category") %>'></asp:Label>
                        </td>
                        <td> 
                            <asp:Label ID="lblQty" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Qty") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnRemove" Text="Remove Item" runat="server" />
                        </td>
            
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
            </table>


            <br />
            <div class="centerAlignment">
                 <asp:Label ID="lblRestName" runat="server" Font-Size="30pt" Text="Restaurant Menu"></asp:Label>

            </div>
            <asp:Button ID="btnConfirm" runat="server" Text="Add to Order List" OnClick="btnConfirm_Click" />
            <br />
            <br />
            <asp:GridView ID="gvSelectedRestMenu" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ItemId" HeaderText="ID" SortExpression="ItemId" />
                    <asp:ImageField DataImageUrlField="ImageURL" HeaderText="Image" ControlStyle-Height="100px" ControlStyle-Width="100px">
                    </asp:ImageField>
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" DataFormatString="{0:c}" />
                    <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                    <asp:TemplateField HeaderText="Qty">
                        <ItemTemplate>
                            <asp:TextBox ID="txtQty" runat="server"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <div class="divider2"></div>
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
