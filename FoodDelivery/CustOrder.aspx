<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustOrder.aspx.cs" Inherits="FoodDelivery.CustOrder" %>

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
     .auto-style2 {
         height: 26px;
     }
     td{
         text-align:center;
     }
     th{
         text-align: center;
     }
     h2{
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
    <h2>Order History</h2>
    <form id="form1" runat="server">
        
        <div>

            <br />
            <br />
            <br />
            <br />
            <table>
                <tr>
                    <th>Item Name</th>
                    <th>Description</th>
                    <th class="auto-style1">Price</th>
                    
                    <th>Quantity</th>
                    <th>Order Date</th>
                    
                    
                </tr>
                <asp:Repeater ID="rptOrderOutput" runat="server" Visible="true" >
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
                            <asp:Label ID="lblQty" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Qty") %>'></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="lblDate" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "OrderTime") %>'></asp:Label>
                        </td>
                        
                    </tr>

                </ItemTemplate>
            </asp:Repeater>
            </table>
            <br />
            <br />

        </div>
    </form>
</body>
</html>
