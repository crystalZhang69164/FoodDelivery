using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace FoodDelivery
{
    public partial class OrderNow : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        Order orderList = new Order();
        int nameCOL = 3;
        int descriptionCOL = 4;
        int priceCOL = 5;
        int categoryCOL = 6;




        protected void Page_Load(object sender, EventArgs e)
        {
            Order orderListCart = new Order();
            string restName = Session["selectedRestName"].ToString();
            int restID = Convert.ToInt16(Session["selectedRestID"].ToString());

            lblRestName.Text = restName + "'s Menu";

            string sql = "SELECT * FROM TP_Item WHERE RestId = " + restID;

            if (!IsPostBack)
            {
                DataSet myData = dbConnect.GetDataSet(sql);
                gvSelectedRestMenu.DataSource = myData;
                gvSelectedRestMenu.DataBind();
            }
            
        }
        public List<Item> getOrderListCart(List<Item> orderList)
        {
            List<Item> l = new List<Item>();
            List<Item> temp = new List<Item>();

            for (int i = 0; i < orderList.Count; i++)
            {
                //l.Add(orderList.);

                
            }


            return l;
        }

        //get this from the coffe shop
        public Boolean validQty()
        {
            CheckBox chkBox;
            TextBox tBox;

            for (int row=0; row<gvSelectedRestMenu.Rows.Count; row++)
            {
                
                chkBox = (CheckBox)gvSelectedRestMenu.Rows[row].FindControl("chkSelect");

                if (chkBox.Checked)
                {
                    tBox = (TextBox)gvSelectedRestMenu.Rows[row].FindControl("txtQty");

                    if (tBox.Text != "" && int.TryParse(tBox.Text, out int quantity) == true)
                    {
                        return true;
                    }
                    else
                    {
                        Response.Write("Please enter a valid quantity");
                        return false;
                    }
                }
                

            }

            return false;
        }
        //the add to order list btn event
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            if (validQty() == true)
            {
                CheckBox chkBox;

                for (int row = 0; row < gvSelectedRestMenu.Rows.Count; row++ )
                {
                    chkBox = (CheckBox)gvSelectedRestMenu.Rows[row].FindControl("chkSelect");
                    if (chkBox.Checked)
                    {
                        //adds all the items to the orderlist and their attributes that 
                        //have been checked
                        Item items = new Item();

                        items.Name = gvSelectedRestMenu.Rows[row].Cells[nameCOL].Text.ToString();
                        items.Description = gvSelectedRestMenu.Rows[row].Cells[descriptionCOL].Text.ToString();
                        items.Price = double.Parse(gvSelectedRestMenu.Rows[row].Cells[priceCOL].Text.Split('$')[1]);
                        items.Category = gvSelectedRestMenu.Rows[row].Cells[categoryCOL].Text.ToString();

                        //gets the qty from the txtbox ctrl
                        TextBox tBoxQty;
                        tBoxQty = (TextBox)gvSelectedRestMenu.Rows[row].FindControl("txtQty");
                        items.Qty = int.Parse(tBoxQty.Text);

                        orderList.AddItem(items);

                    }

                }

                displayOrder();

                rptOrderOutput.Visible = true;
            }
            
        }
        public void displayOrder()
        {
            //display order to repeater
            //rptOrderOutput.DataSource = orderList.getItemList();
            //rptOrderOutput.DataBind();

            //binds the array list to the gv
            gvOrderOutput.DataSource = orderList.getItemList();
            gvOrderOutput.DataBind();


        }

        protected void rptOrderOutput_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

        }

        //incomplete
        protected void rptOrderOutput_RemoveCommand(object source, RepeaterCommandEventArgs e)
        {
            int size = orderList.Size;
            // Retrieve the row index for the item that fired the ItemCommand event
            int rowIndex = e.Item.ItemIndex;
            rptOrderOutput.DataSource = orderList.removeItem(rowIndex, size);

            displayOrder();
        }

        //done
        protected void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i<orderList.Size; i++)
            {
                gvOrderOutput.DataSource = orderList.clearOrder(i);
            }
            displayOrder();
        }
        //incomplete
        protected void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string name;
            string description;
            //string category;
            double price;
            string status;
            int qty;
            //string imageURL;
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int custId = Convert.ToInt16(objCookie["custId"].ToString());
            int restID = Convert.ToInt16(Session["selectedRestID"].ToString());

            //double totalCost;

            int imageCOL = 1;
            int nameCOL = 2;
            int descriptionCOL = 3;
            int priceCOL = 4;
            int qtyCOL = 5;

            for (int row = 0; row < gvOrderOutput.Rows.Count; row++)
            {
                name = gvOrderOutput.Rows[row].Cells[nameCOL].Text.ToString();
                description = gvOrderOutput.Rows[row].Cells[descriptionCOL].Text.ToString();
                price = double.Parse(gvOrderOutput.Rows[row].Cells[priceCOL].Text.Split('$')[1]);
                qty = int.Parse(gvOrderOutput.Rows[row].Cells[qtyCOL].Text);


                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_PlaceOrder";

                //clears the parameters otherwise it will keep on adding them onto each other in 
                //a for loop
                objCommand.Parameters.Clear();
                objCommand.Parameters.AddWithValue("@name", name);
                objCommand.Parameters.AddWithValue("@description", description);
                objCommand.Parameters.AddWithValue("@price", price);
                objCommand.Parameters.AddWithValue("@status", "Submitted");
                objCommand.Parameters.AddWithValue("@orderDate", DateTime.Now);
                objCommand.Parameters.AddWithValue("@qty", qty);
                objCommand.Parameters.AddWithValue("@custId", custId);
                objCommand.Parameters.AddWithValue("@restId", restID);

                dbConnect.DoUpdateUsingCmdObj(objCommand);




            }

            Response.Write("Your Order has been placed");
            

            
            Session["OrderList"] = orderList;
            //Response.Redirect("CustOrder.aspx");

        }

        //incomplete
        protected void gvOrderOutput_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // retrieve the row index for which the Update button was clicked
            int rowIndex = e.RowIndex;
            int size = orderList.Size;
            CheckBox chkBox;

            //HttpCookie objCookie = Request.Cookies["theCookie"];
            //int restId = Convert.ToInt16(objCookie["restId"].ToString());
            for (int row = 0; row < size; row++)
            {

                chkBox = (CheckBox)gvOrderOutput.Rows[row].FindControl("chkRemove");
                if (chkBox.Checked)
                {
                    orderList.removeItem(row, size);

                }
            }
            displayOrder();


        }




        //public void generateOrderList()
        //{
        //    Item item;

        //    //size is a method in the order class that returns the size of the list
        //    for (int i=0; i < orderList.Size; i++)
        //    {
        //        item = new Item();
        //        item.Name = 
        //    }
        //}
    }
}