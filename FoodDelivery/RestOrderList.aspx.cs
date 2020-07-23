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
    public partial class RestOrderList : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        int orderIdCOL = 0;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restId = Convert.ToInt32(objCookie.Values["restId"].ToString());

            if (!IsPostBack)
            {
                string sql = "SELECT * FROM TP_Orders WHERE RestId = " + restId;
                DataSet ordersData = dbConnect.GetDataSet(sql);

                gvOrderHistory.DataSource = ordersData;
                gvOrderHistory.DataBind();
            }
        }

 

        protected void btnChangeStatus_Click(object sender, EventArgs e)
        {
            CheckBox chkBox;
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_ChangeStatus";

            for (int row = 0; row < gvOrderHistory.Rows.Count; row++)
            {
                chkBox = (CheckBox)gvOrderHistory.Rows[row].FindControl("chkComplete");
                if (chkBox.Checked)
                {
                    int orderID = int.Parse(gvOrderHistory.Rows[row].Cells[orderIdCOL].Text);

                    objCommand.Parameters.AddWithValue("@orderID", orderID);
                    objCommand.Parameters.AddWithValue("@status", ddlStatus.Text);


                    dbConnect.DoUpdateUsingCmdObj(objCommand);

                }
            }

            string sql = "SELECT * FROM TP_Orders";
            DataSet ordersData = dbConnect.GetDataSet(sql);

            gvOrderHistory.DataSource = ordersData;
            gvOrderHistory.DataBind();
        }
    }
}