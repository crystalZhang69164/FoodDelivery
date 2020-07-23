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
    public partial class AccRecovery : System.Web.UI.Page
    {
        SqlCommand objCommand = new SqlCommand();
        DBConnect dbConnect = new DBConnect();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Session["AccFound"] = false;
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnGetPassword_Click(object sender, EventArgs e)
        {
            if (txtRecoveryEmail.Text != null)
            {
                string custSQL = "SELECT * FROM TP_Customers";
                string restSQL = "SELECT * FROM TP_Restaurants";
                DataSet custData = dbConnect.GetDataSet(custSQL);
                DataSet restData = dbConnect.GetDataSet(restSQL);
                DataTable custTable = custData.Tables[0];
                DataTable restTable = restData.Tables[0];

                if (Session["AccType"].ToString() == "Customer")
                {
                    for (int row = 0; row< custTable.Rows.Count; row++)
                    {
                        DataRow custRow = custTable.Rows[row];
                        //if the email matches the email in the database
                        //give the user their password
                        if (txtRecoveryEmail.Text == custRow["Email"].ToString())
                        {
                            lblRecoveryPassword.Visible = true;
                            lblRecoveryPassword.Text = "Your Password is: " + custRow["Password"].ToString();
                            Session["AccFound"] = "true";

                        }
                        else
                        {
                            Session["AccFound"] = "false";
                        }
                        
                        
                    }
                    if (Session["AccFound"].ToString() == "false")
                    {
                        Response.Write("The email is not associated with any acc in the database. Please try again");
                    }
                    
                }
                else{
                    for (int row = 0; row < restTable.Rows.Count; row++)
                    {
                        DataRow restRow = restTable.Rows[row];
                        if (txtRecoveryEmail.Text == restRow["Email"].ToString())
                        {
                            lblRecoveryPassword.Visible = true;
                            lblRecoveryPassword.Text = "Your Password is: " + restRow["Password"].ToString();
                            Session["AccFound"] = "true";
                        }
                        else
                        {
                            Session["AccFound"] = "false";
                        }
                    }
                    if (Session["AccFound"].ToString() == "false")
                    {
                        Response.Write("The email is not associated with any acc in the database. Please try again");
                    }
                }


            }
        }

        protected void btnCust_Click(object sender, EventArgs e)
        {
            txtRecoveryEmail.Visible = true;
            lblRecoveryEmail.Visible = true;
            lblRecoveryPassword.Visible = false;
            lblRecoveryPassword.Text = "";
            

           
            Session["AccType"] = "Customer";


        }

        protected void btnRest_Click(object sender, EventArgs e)
        {
            txtRecoveryEmail.Visible = true;
            lblRecoveryEmail.Visible = true;
            lblRecoveryPassword.Visible = false;
            lblRecoveryPassword.Text = "";


            Session["AccType"] = "Restaurant";
        }

        protected void ddlAccType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}