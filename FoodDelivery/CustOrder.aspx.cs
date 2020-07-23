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
    public partial class CustOrder : System.Web.UI.Page
    {
        Order orderList = new Order();
        DBConnect dbConnect = new DBConnect();
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int custID = Convert.ToInt32(objCookie.Values["custId"].ToString());
            

            if (!IsPostBack)
            {
                //orderList = (Order)Session["OrderList"];
                //displayOrder();
                string sql = "SELECT * FROM TP_Orders WHERE CustId = " + custID;
                DataSet myData = dbConnect.GetDataSet(sql);

                rptOrderOutput.DataSource = dbConnect.GetDataSet(sql);
                rptOrderOutput.DataBind();





            }
        }
        public void displayOrder()
        {
            //display order to repeater
            rptOrderOutput.DataSource = orderList.getItemList();
            rptOrderOutput.DataBind();
        }
    }
}