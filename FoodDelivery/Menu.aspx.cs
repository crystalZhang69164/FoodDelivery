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
    public partial class Menu : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        int itemIdCOL = 0;
        
        


        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt32(objCookie.Values["restId"].ToString());
            lblMsg.Text = "";

            if (!IsPostBack)
            {
                
                

                string itemSql = "SELECT * FROM TP_Item WHERE RestId = " + restId + " "+ "ORDER BY ItemId" ;
                DataSet myData = dbConnect.GetDataSet(itemSql);
                DataTable itemTable = myData.Tables[0];

                for (int row = 0; row < itemTable.Rows.Count; row++)
                {
                    DataRow itemRow = itemTable.Rows[row];
                    if (objCookie.Values["restId"].ToString() == itemRow["RestId"].ToString())
                    {
                        gvMenu.DataSource = myData;
                        gvMenu.DataBind();
                    }

                }
            }
            

            //string sql = "SELECT * FROM TP_Item";

            //DataSet itemData = dbConnect.GetDataSet(sql);

            //gvMenu.DataSource = itemData;
            //gvMenu.DataBind();

        }

        protected void btnCreateMenu_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            lblName.Visible = false;
            lblDescription.Visible = false;
            lblPrice.Visible = false;
            lblImage.Visible = false;
            lblCategory.Visible = false;
            lblMsg.Text = "";
            

            
            txtName.Visible = false;
            txtDescription.Visible = false;
            txtPrice.Visible = false;
            ddlCategory.Visible = false;
            lblImage.Visible = false;
            fuFoodImage.Visible = false;

            btnCancel.Visible = false;
            btnAdd.Visible = false;
        }

        

        protected void btnAddNewItem_Click(object sender, EventArgs e)
        {
            lblName.Visible = true;
            lblDescription.Visible = true;
            lblPrice.Visible = true;
            lblImage.Visible = true;
            lblCategory.Visible = true;
            lblMsg.Text = "";

            //makes the image ctrl visible too
            txtName.Visible = true;
            txtDescription.Visible = true;
            txtPrice.Visible = true;
            ddlCategory.Visible = true;

            btnAdd.Visible = true;
            btnCancel.Visible = true;
            fuFoodImage.Visible = true;


        }
        //done
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt16(objCookie["restId"].ToString());
            decimal price = Convert.ToDecimal(txtPrice.Text.ToString());

            try
            {
                //saves the image into the pics folder
                fuFoodImage.SaveAs(Server.MapPath("Pics") + "//" + fuFoodImage.FileName);
                string imageURL = "~/Pics/" + fuFoodImage.FileName.ToString();

                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "TP_AddNewItem";

                objCommand.Parameters.AddWithValue("@name", txtName.Text);
                objCommand.Parameters.AddWithValue("@description", txtDescription.Text);
                objCommand.Parameters.AddWithValue("@price", price);
                objCommand.Parameters.AddWithValue("@category", ddlCategory.Text);
                objCommand.Parameters.AddWithValue("@restId", restId);
                objCommand.Parameters.AddWithValue("@imageURL", imageURL);

                dbConnect.DoUpdateUsingCmdObj(objCommand);

                string menuSql = "SELECT * FROM TP_Item WHERE RestId = " + restId + " " + "ORDER BY Category";
                DataSet mydataSet = dbConnect.GetDataSet(menuSql);

                gvMenu.DataSource = mydataSet;
                gvMenu.DataBind();

                //Response.Write("Your Item has been added");
                lblMsg.Text = "Your Item: " + txtName.Text + " has been added";

                txtName.Text = "";
                txtDescription.Text = "";
                txtPrice.Text = "";
                ddlCategory.Text = ddlCategory.Items[0].Text;
            }
            catch
            {
                lblMsg.Text = "Please upload an image for your item";
            }
            

            
        }
        //done
        protected void btnSort_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt16(objCookie["restId"].ToString());
            lblMsg.Text = "";

            //sort menu by category in asc order
            if (ddlSort.Text == "ASC")
            {
                string sortASC = "SELECT * FROM TP_Item WHERE RestId = " + restId + " " + "ORDER BY Category ASC";

                DataSet myDataSet = dbConnect.GetDataSet(sortASC);

                gvMenu.DataSource = myDataSet;
                gvMenu.DataBind();
            }
            //sort menu by category in desc order
            else
            {
                string sortDESC = "SELECT * FROM TP_Item WHERE RestId = " + restId + " " + "ORDER BY Category DESC";

                DataSet myDataSet = dbConnect.GetDataSet(sortDESC);

                gvMenu.DataSource = myDataSet;
                gvMenu.DataBind();
            }

            
        }

        //the command fields events
        //--------------------------------------------------------------------------------
        //event handler when the edit button is 
        //done
        protected void gvMenu_RowEditing(object sender, GridViewEditEventArgs e)
        {
            //sets the row to edit mode in the gv
            gvMenu.EditIndex = e.NewEditIndex;
            
            ShowMenu();
            lblMsg.Text = "";


        }

        public void ShowMenu()
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt16(objCookie["restId"].ToString());

            string strSQL = "SELECT * FROM TP_Item WHERE RestId = " + restId;
            DataSet myData = dbConnect.GetDataSet(strSQL);

            gvMenu.DataSource = myData;
            gvMenu.DataBind();
        }
        //command field update buutton event 
        //incomplete
        protected void gvMenu_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            // retrieve the row index for which the Update button was clicked
            int rowIndex = e.RowIndex;
            int nameCOL = 2;
            int descriptionCOL = 3;
            int priceCOL = 4;
            int categoryCOL = 5;
            TextBox tBox;




            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt16(objCookie["restId"].ToString());

            string itemID = gvMenu.Rows[rowIndex].Cells[itemIdCOL].Text;
            ////retreive the items name 2nd col bound field in that row
            //string name = gvMenu.Rows[rowIndex].Cells[nameCOL].Text;
            //string description = gvMenu.Rows[rowIndex].Cells[descriptionCOL].Text;
            //string price = gvMenu.Rows[rowIndex].Cells[priceCOL].Text;
            //string category = gvMenu.Rows[rowIndex].Cells[categoryCOL].Text;

            ////gets a reference to the txtBox in the row for the item name to add
            //TextBox tBox;
            //tBox = (TextBox)gvMenu.Rows[rowIndex].FindControl("txtGvItemName");
            //string name = tBox.Text;


            //tBox = (TextBox)gvMenu.Rows[rowIndex].FindControl("txtGvDescription");
            //string description = tBox.Text;

            //tBox = (TextBox)gvMenu.Rows[rowIndex].FindControl("txtGvPrice");
            //double price = double.Parse(tBox.Text);

            //tBox = (TextBox)gvMenu.Rows[rowIndex].FindControl("txtGvCategory");
            //string category = tBox.Text;
            tBox = (TextBox)gvMenu.Rows[rowIndex].FindControl("");

            string name = gvMenu.SelectedRow.Cells[nameCOL].Text;
            //string name = gvMenu.Rows[rowIndex].Cells[nameCOL].Text.ToString();
            string description = gvMenu.Rows[rowIndex].Cells[descriptionCOL].Text.ToString();
            double price = double.Parse(gvMenu.Rows[rowIndex].Cells[priceCOL].Text);
            string category = gvMenu.Rows[rowIndex].Cells[categoryCOL].ToString();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateItemInfo";

            objCommand.Parameters.AddWithValue("@name", name);
            objCommand.Parameters.AddWithValue("@description", description);
            objCommand.Parameters.AddWithValue("@price", price);
            objCommand.Parameters.AddWithValue("@category", category);
            objCommand.Parameters.AddWithValue("@restId", restId);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            gvMenu.EditIndex = -1;
            ShowMenu();

            //Response.Write("Your Menu Item: " + itemID + " has been Update");
            lblMsg.Text = "Your Menu Item: " + itemID + " has been Update";


        }
        //done
        protected void gvMenu_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            // Set the GridView back to the original state

            // No rows currently being editted

            gvMenu.EditIndex = -1;
            lblMsg.Text = "";


            ShowMenu();
        }

        //delete btn event
        //done
        protected void gvMenu_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // retrieve the row index for which the Update button was clicked
            int rowIndex = e.RowIndex;

            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt16(objCookie["restId"].ToString());
            //get the item id in the 1st col of the gv in that row
            string itemID = gvMenu.Rows[rowIndex].Cells[itemIdCOL].Text;

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_DeleteMenuItem";

            objCommand.Parameters.AddWithValue("@restID", restId);
            objCommand.Parameters.AddWithValue("@itemID", itemID);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            //set gridview back to normal state (turn off edit mode)
            gvMenu.EditIndex = -1;
            //rebinds the gv
            ShowMenu();

            //Response.Write("Your Menu Item " + itemID + " has been Deleted");
            lblMsg.Text = "Your Menu Item " + itemID + " has been Deleted";

        }
    }
}