using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using Utilities;

using System.Web.Script.Serialization;  // needed for JSON serializers
using System.IO;                        // needed for Stream and Stream Reader
using System.Net;                       // needed for the Web Request



namespace FoodDelivery
{
    public partial class SignUp : System.Web.UI.Page
    {
        bool customerRegistrationFlag;
        bool restuarantRegistrationFlag;
        bool isUniqueAcc = false;
        SqlCommand objCommand = new SqlCommand();
        DBConnect dbConnect = new DBConnect();
        int merchantID = 0;
        string apiKey = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                customerRegistrationFlag = false;
                restuarantRegistrationFlag = false;
            }

        }
        protected void btnRestaurant_Click(object sender, EventArgs e)
        {
            restuarantRegistrationFlag = true;
            customerRegistrationFlag = false;
            showRestaurantBtns();
            //string restFlag = "Restaurant";
            Session["AccType"] = "Restaurant";

            lblBankInfo.Visible = true;
            lblCardType.Visible = true;
            lblCardNum.Visible = true;

            txtCardNum.Visible = true;
            ddlCardType.Visible = true;


            btnBack.Visible = true;
            btnCreate.Visible = true;
        }

        protected void btnCustomer_Click(object sender, EventArgs e)
        {
            customerRegistrationFlag = true;
            restuarantRegistrationFlag = false;
            showCustomerBtns();
            //string custFlag = "Customer";
            Session["AccType"] = "Customer";

            lblBankInfo.Visible = true;
            lblCardType.Visible = true;
            lblCardNum.Visible = true;

            txtCardNum.Visible = true;
            ddlCardType.Visible = true;

            btnBack.Visible = true;
            btnCreate.Visible = true;

        }

        public bool validInput()
        {
            if (Session["AccType"].ToString() == "Customer")
            {
                if (txtCEmail.Text != "" && txtCPassword.Text != "" && txtCAddress.Text != "" && txtCCity.Text != "" &&
                    ddlCState.Text != "" && txtCZipCode.Text != "" && txtBillingAddress.Text != "" && txtBillingCity.Text != "" &&
                    ddlBillingState.Text != "" && txtBillingZipCode.Text != "" && ddlCardType.Text != "" && int.TryParse(txtCZipCode.Text, out int cZipCode) && int.TryParse(txtBillingZipCode.Text, out int billingZipCode)
                    && int.TryParse(txtBillingZipCode.Text, out int cBillingZipCode) && int.TryParse(txtCardNum.Text, out int cardNum))
                {
                    return true;
                }
                else
                {
                    Response.Write("Please fill in all fields correctly");

                    return false;
                }
            }
            if (Session["AccType"].ToString() == "Restaurant")
            {
                if (txtREmail.Text != "" && txtRPassword.Text != "" && txtRContactEmail.Text != "" && txtRAddress.Text != "" &&
                    txtPhone.Text != "" && txtRAddress.Text != "" && txtRCity.Text != "" && ddlRState.Text != "" && txtRestName.Text != "" &&
                    txtRZipCode.Text != "" && txtDescription.Text != "" && ddlCardType.Text != "" && int.TryParse(txtRZipCode.Text, out int rZipCode) && int.TryParse(txtPhone.Text, out int phone)
                    && int.TryParse(txtCardNum.Text, out int cardNum))
                {
                    return true;
                }
                else
                {
                    Response.Write("Please fill in all fields correctly");
                    return false;
                }
            }

            return false;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            //validations
            if (Session["AccType"].ToString() == "Customer" && validInput())
            {
                string sql = "SELECT * FROM TP_Customers";
                DataSet myData = dbConnect.GetDataSet(sql);
                DataTable myTable = myData.Tables[0];

                for (int row = 0; row<myTable.Rows.Count; row++)
                {
                    DataRow dataRow = myTable.Rows[row];
                    if (txtCEmail.Text == dataRow["Email"].ToString())
                    {
                        //isUniqueAcc = false;
                        //acc is taken
                        Session["UniqueAcc"] = "false";

                        
                    }
                    else
                    {
                        //acc is available
                        //isUniqueAcc = true;
                        Session["UniqueAcc"] = "true";
                        
                    }
                }
                if (Session["UniqueAcc"].ToString() == "true")
                {

                    Customers customer = new Customers();


                    customer.CustomerEmail = txtCEmail.Text;
                    customer.Password = txtCPassword.Text;
                    customer.DeliveryAddress = txtCAddress.Text;
                    customer.DeliveryCity = txtCCity.Text;
                    customer.DeliveryState = ddlCState.Text;
                    customer.DeliveryZipCode = txtCZipCode.Text;
                    customer.BillingAddress = txtBillingAddress.Text;


                    customer.BillingCity = txtBillingCity.Text;
                    customer.BillingState = ddlBillingState.Text;
                    customer.BillingZipCode = txtBillingZipCode.Text;

                    //// Create an HTTP Web Request and get the HTTP Web Response from the server.
                    //WebRequest request = WebRequest.Create("http://cis-iis2.temple.edu/Fall2019/CIS3342_tuf62563/TermProjectWS/api/service/PaymentGateway/CreateVirtualWallet");

                    //WebResponse response = request.GetResponse();
                    //// Read the data from the Web Response, which requires working with streams.
                    //Stream theDataStream = response.GetResponseStream();
                    //StreamReader reader = new StreamReader(theDataStream);
                    //String data = reader.ReadToEnd();
                    //int walletID = Int32.Parse(data);
                    //reader.Close();
                    //response.Close();

                    //VirtualWallet wallet = new VirtualWallet();
                    //wallet.WalletID = walletID;


                    ////Deserialize a JSON string into a Team object.

                    //JavaScriptSerializer js = new JavaScriptSerializer();
                    ////wallet.WalletID = js.Deserialize<VirtualWallet>(data);

                    //string jsonWallet = js.Serialize(wallet);

                    //try
                    //{
                    //    WebRequest request = WebRequest.Create("");
                    //    WebResponse response = request.GetResponse();
                    //    // Read the data from the Web Response, which requires working with streams.
                    //    Stream theDataStream = response.GetResponseStream();
                    //    StreamReader reader = new StreamReader(theDataStream);
                    //    String data = reader.ReadToEnd();
                    //    reader.Close();
                    //    response.Close();
                    //}


                    //add store procedure to add into the CUSTOMER DATABASE
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "TP_InsertCustomers";

                    objCommand.Parameters.AddWithValue("@email", customer.CustomerEmail);
                    objCommand.Parameters.AddWithValue("@password", customer.Password);
                    objCommand.Parameters.AddWithValue("@address", customer.DeliveryAddress);
                    objCommand.Parameters.AddWithValue("@city", customer.DeliveryCity);
                    objCommand.Parameters.AddWithValue("@state", customer.DeliveryState);
                    objCommand.Parameters.AddWithValue("@zipCode", customer.DeliveryZipCode);
                    objCommand.Parameters.AddWithValue("@billingAddress", customer.BillingAddress);
                    objCommand.Parameters.AddWithValue("@billingCity", customer.BillingCity);
                    objCommand.Parameters.AddWithValue("@billingState", customer.BillingState);
                    objCommand.Parameters.AddWithValue("@billingZipCode", customer.BillingZipCode);
                    //objCommand.Parameters.AddWithValue("@walletID", wallet.WalletID);

                    dbConnect.DoUpdateUsingCmdObj(objCommand);


                    


                    Response.Redirect("Login.aspx");

                }
                else
                {
                    Response.Write("This account already exists");
                }
                
            }
            //restaruant check

            //messing around with rest check make sure customer is the same
            
            if (Session["AccType"].ToString() == "Restaurant" && validInput())
            {
                string sql = "SELECT * FROM TP_Restaurants";
                DataSet myData = dbConnect.GetDataSet(sql);
                DataTable myTable = myData.Tables[0];

                for (int row = 0; row < myTable.Rows.Count; row++)
                {
                    DataRow dataRow = myTable.Rows[row];
                    if (txtREmail.Text != dataRow["Email"].ToString())
                    {
                        isUniqueAcc = true;
                        Session["UniqueAcc"] = "true";
                        Session["restID"] = Convert.ToInt32(dataRow["Id"].ToString());

                    }
                    else
                    {

                        isUniqueAcc = false;
                        Session["UniqueAcc"] = "false";

                        return;

                    }
                }
                //if the acc is unique add the acc to the database
                if (Session["UniqueAcc"].ToString() == "true")
                {
                    Restaurants restaurant = new Restaurants();


                    restaurant.RestaurantEmail = txtREmail.Text;
                    restaurant.Password = txtRPassword.Text;
                    restaurant.Address = txtRAddress.Text;
                    restaurant.Name = txtRestName.Text;
                    restaurant.Image = "";
                    restaurant.ContactEmail = txtRContactEmail.Text;
                    restaurant.PhoneNumber = txtPhone.Text;
                    restaurant.City = txtRCity.Text;
                    restaurant.State = ddlRState.Text;
                    restaurant.ZipCode = txtRZipCode.Text;
                    restaurant.RestaurantType = ddlRType.Text;
                    restaurant.CuisineType = ddlRCuisineType.Text;
                    restaurant.Description = txtDescription.Text;

                    //saves the image into the pics folder
                    fuRestImage.SaveAs(Server.MapPath("RestPics") + "//" + fuRestImage.FileName);
                    string imageURL = "~/RestPics/" + fuRestImage.FileName.ToString();

                    //add store procedure to add into the Restaurant DATABASE
                    objCommand.CommandType = CommandType.StoredProcedure;
                    objCommand.CommandText = "TP_InsertRestaurants";

                    objCommand.Parameters.AddWithValue("@email", restaurant.RestaurantEmail);
                    objCommand.Parameters.AddWithValue("@password", restaurant.Password);
                    objCommand.Parameters.AddWithValue("@contact_email", restaurant.ContactEmail);
                    objCommand.Parameters.AddWithValue("@name", restaurant.Name);
                    objCommand.Parameters.AddWithValue("@image", imageURL);
                    objCommand.Parameters.AddWithValue("@phone_number", restaurant.PhoneNumber);
                    objCommand.Parameters.AddWithValue("@address", restaurant.Address);
                    objCommand.Parameters.AddWithValue("@city", restaurant.City);
                    objCommand.Parameters.AddWithValue("@state", restaurant.State);
                    objCommand.Parameters.AddWithValue("@zipCode", restaurant.ZipCode);
                    objCommand.Parameters.AddWithValue("@restaurantType", restaurant.RestaurantType);
                    objCommand.Parameters.AddWithValue("@cuisineType", restaurant.CuisineType);
                    objCommand.Parameters.AddWithValue("@description", restaurant.Description);


                    dbConnect.DoUpdateUsingCmdObj(objCommand);


                    ////the storing info into the cookie
                    //HttpCookie myCookie = new HttpCookie("theCookie");
                    //myCookie.Values["Email"] = restaurant.RestaurantEmail;
                    //myCookie.Values["Password"] = restaurant.Password;
                    //myCookie.Values["restId"] = Session["restID"].ToString();
                    //myCookie.Expires = new DateTime(2020, 1, 1);
                    //Response.Cookies.Add(myCookie);

                    //int restId = Convert.ToInt32(myCookie.Values["restId"]);

                    //objCommand.CommandType = CommandType.StoredProcedure;
                    //objCommand.CommandText = "TP_CreateMenu";

                    //objCommand.Parameters.Clear();
                    //objCommand.Parameters.AddWithValue("@menuID", restId);
                    //objCommand.Parameters.AddWithValue("@restID", restId);

                    //dbConnect.DoUpdateUsingCmdObj(objCommand);


                    Response.Redirect("Login.aspx");
                    
                }
                else
                {
                    Response.Write("This account already exists");
                }
            }



            //Response.Redirect("Login.aspx");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void showRestaurantBtns()
        {
            lblRegistrationType.Visible = true;
            lblRegistrationType.Text = "Restaurant Registration";
            restuarantRegistrationFlag = true;
            customerRegistrationFlag = false;

            
            lblCEmail.Visible = false;
            txtCEmail.Visible = false;
            lblCPassword.Visible = false;
            txtCPassword.Visible = false;

            lblDeliveryInfo.Visible = false;
            lblCAddress.Visible = false;
            txtCAddress.Visible = false;
            lblCCity.Visible = false;
            txtCCity.Visible = false;
            lblCState.Visible = false;
            ddlCState.Visible = false;
            lblCZipCode.Visible = false;
            txtCZipCode.Visible = false;


            lblBillingInfo.Visible = false;

            lblBillingAddress.Visible = false;
            txtBillingAddress.Visible = false;

            lblBillingCity.Visible = false;
            txtBillingCity.Visible = false;
            lblBillingState.Visible = false;
            ddlBillingState.Visible = false;
            lblBillingZipCode.Visible = false;
            txtBillingZipCode.Visible = false;


            //------------------------------------
            //making the restaturant sign up controls visible
            lblRestName.Visible = true;
            txtRestName.Visible = true;
            lblREmail.Visible = true;
            txtREmail.Visible = true; 
            lblRPassword.Visible = true;
            txtRPassword.Visible = true;
            lblImage.Visible = true;
            fuRestImage.Visible = true;
            lblRContactInfo.Visible = true;
            lblRContactEmail.Visible = true;
            txtRContactEmail.Visible = true;
            lblRAddress.Visible = true;
            txtRAddress.Visible = true;
            lblRCity.Visible = true;
            txtRCity.Visible = true;
            lblRState.Visible = true;
            ddlRState.Visible = true;
            lblRZipCode.Visible = true;
            txtRZipCode.Visible = true;

            lblRestaruantInfo.Visible = true;
            lblRType.Visible = true;
            ddlRType.Visible = true;
            lblCuisineType.Visible = true;
            ddlRCuisineType.Visible = true;
            lblDescription.Visible = true;
            txtDescription.Visible = true;
            lblPhone.Visible = true;
            txtPhone.Visible = true;
        }
        public void showCustomerBtns()
        {
            lblRegistrationType.Visible = true;
            lblRegistrationType.Text = "Customer Registration";
            
            restuarantRegistrationFlag = false;
            customerRegistrationFlag = true;

            lblCEmail.Visible = true;
            txtCEmail.Visible = true;
            lblCPassword.Visible = true;
            txtCPassword.Visible = true;

            lblDeliveryInfo.Visible = true;
            lblCAddress.Visible = true;
            txtCAddress.Visible = true;
            lblCCity.Visible = true;
            txtCCity.Visible = true;
            lblCState.Visible = true;
            ddlCState.Visible = true;
            lblCZipCode.Visible = true;
            txtCZipCode.Visible = true;


            lblBillingInfo.Visible = true;

            lblBillingAddress.Visible = true;
            txtBillingAddress.Visible = true;

            lblBillingCity.Visible = true;
            txtBillingCity.Visible = true;
            lblBillingState.Visible = true;
            ddlBillingState.Visible = true;
            lblBillingZipCode.Visible = true;
            txtBillingZipCode.Visible = true;


            //------------------------------------
            //making the restaturant sign up controls invisible

            lblRestName.Visible = false;
            txtRestName.Visible = false;
            lblREmail.Visible = false;
            txtREmail.Visible = false; 
            lblRPassword.Visible = false;
            txtRPassword.Visible = false;
            lblImage.Visible = false;
            fuRestImage.Visible = false;
            lblRContactInfo.Visible = false;
            lblRContactEmail.Visible = false;
            txtRContactEmail.Visible = false;
            lblRAddress.Visible = false;
            txtRAddress.Visible = false;
            lblRCity.Visible = false;
            txtRCity.Visible = false;
            lblRState.Visible = false;
            ddlRState.Visible = false;
            lblRZipCode.Visible = false;
            txtRZipCode.Visible = false;

            lblRestaruantInfo.Visible = false;
            lblRType.Visible = false;
            ddlRType.Visible = false;
            lblCuisineType.Visible = false;
            ddlRCuisineType.Visible = false;
            lblDescription.Visible = false;
            txtDescription.Visible = false;
            lblPhone.Visible = false;
            txtPhone.Visible = false;
        }

        

       
    }
}