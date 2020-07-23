<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="FoodDelivery.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <style>
        body{
            background-color:wheat;
        }
    </style>
<head runat="server">
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
    <title>SignUp</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Account Sign Up</h1>
        <asp:Label runat="server" Font-Size="15pt">Choose Registration Type</asp:Label>
        <br />
        <asp:Button runat="server" Text="Customer" ID="btnCustomer" OnClick="btnCustomer_Click"/>
        <div class="divider2"></div>
        <asp:Button runat="server" Text="Restaurant" ID="btnRestaurant" OnClick="btnRestaurant_Click"/>
        <p>&nbsp;</p>
        <asp:Label Text="Customer Registration" runat="server" ID="lblRegistrationType" Font-Size="20pt" Visible="False"></asp:Label>
        <br />
        
        <p>
            <asp:Label ID="lblCEmail" runat="server" Text="Email Address:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCEmail" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblREmail" runat="server" Text="Restaruant Email:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtREmail" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCPassword" runat="server" Text="Password:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCPassword" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblRPassword" runat="server" Text="Password:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRPassword" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblRestName" runat="server" Text="Restaurant Name:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRestName" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblImage" runat="server" Text="Image:" Visible="False"></asp:Label>
            <asp:FileUpload ID="fuRestImage" runat="server" Visible="False" />
        </p>
        <p>
            
            <asp:Label ID="lblRContactInfo" runat="server" Font-Size="20pt" Text="Contact Information:" Visible="False"></asp:Label>
            
        </p>
        <p>
            <asp:Label ID="lblDeliveryInfo" runat="server" Font-Size="20pt" Text="Delivery Information:" Visible="False"></asp:Label>
            <asp:Label ID="lblRContactEmail" runat="server" Text="Contact Email:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRContactEmail" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCAddress" runat="server" Text="Address:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCAddress" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblPhone" runat="server" Text="Phone Number" Visible="False"></asp:Label>
            <asp:TextBox ID="txtPhone" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCCity" runat="server" Text="City:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCCity" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblRAddress" runat="server" Text="Address:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRAddress" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCState" runat="server" Text="State:" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlCState" runat="server" Visible="False">
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
            <asp:Label ID="lblRCity" runat="server" Text="City:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRCity" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblCZipCode" runat="server" Text="Zip Code:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCZipCode" runat="server" Height="25px" Visible="False" Width="168px"></asp:TextBox>
            <asp:Label ID="lblRState" runat="server" Text="State" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlRState" runat="server" Visible="False">
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
        </p>
            <asp:Label ID="lblRZipCode" runat="server" Text="Zip Code:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtRZipCode" runat="server" Visible="False"></asp:TextBox>
        <br />
        <asp:Label ID="lblBillingInfo" runat="server" Font-Size="20pt" Text="Billing Information:" Visible="False"></asp:Label>
        <asp:Label ID="lblRestaruantInfo" runat="server" Font-Size="20pt" Text="Restaruant Information:" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblBillingAddress" runat="server" Text="Address:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtBillingAddress" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblRType" runat="server" Text="Restaruant Type:" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlRType" runat="server" Visible="False">
                <asp:ListItem>Fast Food</asp:ListItem>
                <asp:ListItem>Cafe</asp:ListItem>
                <asp:ListItem>Buffet</asp:ListItem>
                <asp:ListItem>Family Dining</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblBillingCity" runat="server" Text="City:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtBillingCity" runat="server" Visible="False"></asp:TextBox>
            <asp:Label ID="lblCuisineType" runat="server" Text="Cuisine Type:" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlRCuisineType" runat="server" Visible="False">
                <asp:ListItem>Chinese</asp:ListItem>
                <asp:ListItem>Japanese</asp:ListItem>
                <asp:ListItem>Italian</asp:ListItem>
                <asp:ListItem>American</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblBillingState" runat="server" Text="State:" Visible="False"></asp:Label>
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
            <asp:Label ID="lblDescription" runat="server" Text="Restaruant Description:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtDescription" runat="server" Visible="False" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblBillingZipCode" runat="server" Text="Zip Code:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtBillingZipCode" runat="server" Visible="False"></asp:TextBox>
        <p>
            <asp:Label ID="lblBankInfo" runat="server" Font-Size="20pt" Text="Bank Information" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="lblCardType" runat="server" Text="Card Type:" Visible="False"></asp:Label>
            <asp:DropDownList ID="ddlCardType" runat="server" Visible="False">
                <asp:ListItem>Credit</asp:ListItem>
                <asp:ListItem>Debit</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:Label ID="lblCardNum" runat="server" Text="Card Number:" Visible="False"></asp:Label>
            <asp:TextBox ID="txtCardNum" runat="server" Visible="False"></asp:TextBox>
        </p>
        <p>
            
        </p>
            <div class="divider2"></div>
            <asp:Button ID="btnCreate" runat="server" Text="Create Account" OnClick="btnCreate_Click" Visible="False" />
            <div class="divider2"></div>
            <asp:Button ID="btnBack" runat="server" Text="Back" OnClick="btnBack_Click" Visible="False" />
            
        <p>&nbsp;</p>
        
    </form>
</body>
</html>
