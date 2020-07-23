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
    public partial class Login : System.Web.UI.Page
    {
        SqlCommand objCommand = new SqlCommand();
        DBConnect dbConnect = new DBConnect();
        bool accFound = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignUp.aspx");
        }

        //CHECK IF ALL THE TABLE NAMES AND COL NAMES ARE CORRECT AND SPELLED EXACTLY THE SAME
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtPassword.Text != "")
            {
                string sqlCust = "SELECT * FROM TP_Customers";
                string sqlRestautant = "SELECT * FROM TP_Restaurants";
                DataSet custData = dbConnect.GetDataSet(sqlCust);
                DataSet restaurantData = dbConnect.GetDataSet(sqlRestautant);

                DataTable custTable = custData.Tables[0];
                DataTable restuarantTable = restaurantData.Tables[0];


                for (int row = 0; row < custTable.Rows.Count; row++)
                {
                    DataRow custRow = custTable.Rows[row];


                    if (txtEmail.Text == custRow["Email"].ToString() && txtPassword.Text == custRow["Password"].ToString())
                    {
                        accFound = true;


                        //the storing info into the cookie
                        HttpCookie myCookie = new HttpCookie("theCookie");
                        myCookie.Values["Email"] = txtEmail.Text;
                        myCookie.Values["Password"] = txtPassword.Text;
                        myCookie.Values["custId"] = custRow["Id"].ToString();
                        myCookie.Expires = new DateTime(2020, 1, 1);
                        Response.Cookies.Add(myCookie);


                        Response.Redirect("Customer.aspx");
                    }
                }
                for (int row = 0; row< restuarantTable.Rows.Count; row++)
                {
                    DataRow restaurantRow = restuarantTable.Rows[row];
                    if (txtEmail.Text == restaurantRow["Email"].ToString() && txtPassword.Text == restaurantRow["Password"].ToString())
                    {
                        accFound = true;

                        //the storing info into the cookie
                        HttpCookie myCookie = new HttpCookie("theCookie");
                        myCookie.Values["Email"] = txtEmail.Text;
                        myCookie.Values["Password"] = txtPassword.Text;
                        myCookie.Values["restId"] = restaurantRow["Id"].ToString();
                        myCookie.Values["restName"] = restaurantRow["Name"].ToString();
                        myCookie.Expires = new DateTime(2020, 1, 1);
                        Response.Cookies.Add(myCookie);

                        Response.Redirect("Restaurant.aspx");
                    }
                    
                }
                

            }
            if(accFound == false)
            {
                Response.Write("Account not found");
            }
        }

        protected void linkbtnForgotPW_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccRecovery.aspx");
        }
    }
}