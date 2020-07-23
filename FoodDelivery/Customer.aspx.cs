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
    public partial class Customer : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        int restIdCOL = 0;
        int restNameCOL = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            string strSQL = "SELECT * FROM TP_Restaurants";

            
            DataSet myData = dbConnect.GetDataSet(strSQL);
            gvRestList.DataSource = myData;

            gvRestList.DataBind();
            
        }

        //best search query
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_SearchForRest";

            objCommand.Parameters.AddWithValue("@searchWord", txtSearch.Text);

            dbConnect.GetDataSetUsingCmdObj(objCommand);

            DataSet myData = dbConnect.GetDataSetUsingCmdObj(objCommand);
            gvRestList.DataSource = myData;
            gvRestList.DataBind();

            
        }

        

        public void showMenu(int restID)
        {

            string sql = "SELECT * FROM TP_Item WHERE RestId = " + restID;
        }

        protected void gvRestList_SelectedIndexChanged(object sender, EventArgs e)
        {

            //gets the restID from the selected grid view row that the btn was clicked
            int restId = Convert.ToInt32(gvRestList.SelectedRow.Cells[restIdCOL].Text.ToString());
            Session["selectedRestID"] = restId; 

            string restName = gvRestList.SelectedRow.Cells[restNameCOL].Text.ToString();
            Session["selectedRestName"] = restName;

            Response.Redirect("OrderNow.aspx");
        }
    }
}