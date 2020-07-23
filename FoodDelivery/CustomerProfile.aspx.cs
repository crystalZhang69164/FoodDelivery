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
    public partial class CustomerProfile : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        protected void Page_Load(object sender, EventArgs e)
        {
            string custSql = "SELECT * FROM TP_Customers";
            DataSet custData = dbConnect.GetDataSet(custSql);
            DataTable custTable = custData.Tables[0];
            HttpCookie objCookie = Request.Cookies["theCookie"];


            if (!IsPostBack && Request.Cookies["theCookie"] != null)
            {


                for (int row = 0; row < custTable.Rows.Count; row++)
                {
                    DataRow custRow = custTable.Rows[row];
                    if (objCookie.Values["Email"] == custRow["Email"].ToString())
                    {
                        txtEmail.Text = custRow["Email"].ToString();
                        txtAddress.Text = custRow["Address"].ToString();
                        //add image option
                        
                        
                        txtCity.Text = custRow["City"].ToString();
                        txtState.Text = custRow["State"].ToString();
                        txtZip.Text = custRow["ZipCode"].ToString();
                        txtBillingAddress.Text = custRow["BillingAddress"].ToString();
                        txtBillingCity.Text = custRow["BillingCity"].ToString();
                        txtBillingState.Text = custRow["BillingState"].ToString();
                        txtBillingZipCode.Text = custRow["BillingZipCode"].ToString();
                    }
                }
            }

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            showEditControls();
        }
        

        protected void btnChangePw_Click(object sender, EventArgs e)
        {
            showPasswordControls();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            readOnlyText();

        }
        protected void btnPwCancel_Click(object sender, EventArgs e)
        {
            readOnlyText();
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;
            txtNewPassword.Text = "";
            btnPwCancel.Visible = false;
            btnUpdatePw.Visible = false;
        }
        protected void btnUpdatePw_Click(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateCustPassword";
            HttpCookie objCookie = Request.Cookies["theCookie"];

            int custID = Convert.ToInt32(objCookie.Values["custId"]);

            objCommand.Parameters.AddWithValue("@password", txtNewPassword.Text);
            objCommand.Parameters.AddWithValue("@custId", custID);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            Response.Write("Your Password has been updated");
        }

        protected void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateCustProfile";
            HttpCookie objCookie = Request.Cookies["theCookie"];

            int custID = Convert.ToInt32(objCookie.Values["custId"]);

            //updates customer profile
            objCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            objCommand.Parameters.AddWithValue("@address", txtAddress.Text);
            objCommand.Parameters.AddWithValue("@city", txtCity.Text);
            objCommand.Parameters.AddWithValue("@state", ddlState.Text);
            objCommand.Parameters.AddWithValue("@zip", txtZip.Text);
            objCommand.Parameters.AddWithValue("@billingAddress", txtBillingAddress.Text);
            objCommand.Parameters.AddWithValue("@billingCity", txtBillingCity.Text);
            objCommand.Parameters.AddWithValue("@billingState", txtBillingState.Text);
            objCommand.Parameters.AddWithValue("@billingZip", txtBillingZipCode.Text);
            objCommand.Parameters.AddWithValue("@custId", custID);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            Response.Write("Your Acc Profile has been updated");

            string sql = "SELECT * FROM TP_Customers";
            DataSet custData = dbConnect.GetDataSet(sql);
            DataTable custTable = custData.Tables[0];

            //set the texts to w/e is in the database for that field
            for (int row = 0; row < custTable.Rows.Count; row++)
            {
                DataRow custRow = custTable.Rows[row];
                if (objCookie.Values["Email"] == custRow["Email"].ToString())
                {
                    txtEmail.Text = custRow["Email"].ToString();
                    txtAddress.Text = custRow["Address"].ToString();
                    //add image option                                   
                    txtCity.Text = custRow["City"].ToString();
                    txtState.Text = custRow["State"].ToString();
                    txtZip.Text = custRow["ZipCode"].ToString();
                    txtBillingAddress.Text = custRow["BillingAddress"].ToString();
                    txtBillingCity.Text = custRow["BillingCity"].ToString();
                    txtBillingState.Text = custRow["BillingState"].ToString();
                    txtBillingZipCode.Text = custRow["BillingZipCode"].ToString();

                    txtAddress.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtCity.ReadOnly = true;
                    txtState.ReadOnly = true;

                    txtZip.ReadOnly = true;
                    txtBillingAddress.ReadOnly = true;
                    txtBillingCity.ReadOnly = true;
                    txtBillingState.ReadOnly = true;

                    txtBillingZipCode.ReadOnly = true;

                    btnCancel.Visible = false;
                    btnUpdateInfo.Visible = false;
                }
            }

        }
        public void readOnlyText()
        {
            lblEmail.Visible = true;
            lblAddress.Visible = true;
            lblCity.Visible = true;
            lblState.Visible = true;
            lblZip.Visible = true;
            lblBillingAddress.Visible = true;
            lblBillingCity.Visible = true;
            lblBillingState.Visible = true;
            lblBillingZipCode.Visible = true;

            txtAddress.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            
            txtZip.ReadOnly = true;
            txtBillingAddress.ReadOnly = true;
            txtBillingCity.ReadOnly = true;
            txtBillingState.ReadOnly = true;
            
            txtBillingZipCode.ReadOnly = true;



            txtAddress.Visible = true;
            txtEmail.Visible = true;
            txtCity.Visible = true;
            txtState.Visible = true;
            ddlState.Visible = false;
            txtZip.Visible = true;
            txtBillingAddress.Visible = true;
            txtBillingCity.Visible = true;
            txtBillingState.Visible = true;
            ddlBillingState.Visible = false;
            txtBillingZipCode.Visible = true;

        }
        public void showEditControls()
        {
            lblEmail.Visible = true;
            lblAddress.Visible = true;
            lblCity.Visible = true;
            lblState.Visible = true;
            lblZip.Visible = true;
            lblBillingAddress.Visible = true;
            lblBillingCity.Visible = true;
            lblBillingState.Visible = true;
            lblBillingZipCode.Visible = true;

            txtAddress.Visible = true;
            txtEmail.Visible = true;
            txtCity.Visible = true;

            ddlState.Visible = true;
            txtZip.Visible = true;
            txtBillingAddress.Visible = true;
            txtBillingCity.Visible = true;

            ddlBillingState.Visible = true;
            txtBillingZipCode.Visible = true;


            txtEmail.ReadOnly = false;
            txtAddress.ReadOnly = false;
            txtCity.ReadOnly = false;
            ddlState.Visible = true;
            txtState.Visible = false;
            txtZip.ReadOnly = false;
            txtBillingAddress.ReadOnly = false;
            txtBillingCity.ReadOnly = false;
            ddlBillingState.Visible = true;
            txtBillingState.Visible = false;
            txtBillingZipCode.ReadOnly = false;

            btnCancel.Visible = true;
            btnUpdateInfo.Visible = true;

            //hides pw controls
            lblNewPassword.Visible = false;
            txtNewPassword.Visible = false;

            btnPwCancel.Visible = false;
            btnUpdatePw.Visible = false;

        }
        public void showPasswordControls()
        {

            lblEmail.Visible = false;
            lblAddress.Visible = false;
            lblCity.Visible = false;
            lblState.Visible = false;
            lblZip.Visible = false;
            lblBillingAddress.Visible = false;
            lblBillingCity.Visible = false;
            lblBillingState.Visible = false;
            lblBillingZipCode.Visible = false;

            txtAddress.Visible = false;
            txtEmail.Visible = false;
            txtCity.Visible = false;
            txtState.Visible = false;
            ddlState.Visible = false;
            txtZip.Visible = false;
            txtBillingAddress.Visible = false;
            txtBillingCity.Visible = false;
            txtBillingState.Visible = false;
            ddlBillingState.Visible = false;
            txtBillingZipCode.Visible = false;


            btnCancel.Visible = false;
            btnUpdateInfo.Visible = false;



            //shows pw controls
            lblNewPassword.Visible = true;
            txtNewPassword.Visible = true;

            btnPwCancel.Visible = true;
            btnUpdatePw.Visible = true;
        }

        
    }
}