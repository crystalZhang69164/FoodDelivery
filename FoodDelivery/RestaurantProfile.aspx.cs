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
    public partial class RestaurantProfile : System.Web.UI.Page
    {
        DBConnect dbConnect = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        
        int emailCol = 1;
        int contactEmailCol = 3;
        int imageCol = 4;
        int phoneCol = 5;
        int addressCol = 6;
        int stateCol = 7;
        int zipCol = 8;
        int restTypeCol = 9;
        int cuisineTypeCol = 10;
        int descriptionCol = 11;


        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TP_Restaurants";
            DataSet restData = dbConnect.GetDataSet(sql);
            DataTable restTable = restData.Tables[0];
            HttpCookie objCookie = Request.Cookies["theCookie"];


            if (!IsPostBack && Request.Cookies["theCookie"] != null)
            {
                

                for (int row = 0; row < restTable.Rows.Count; row++)
                {
                    DataRow restRow = restTable.Rows[row];
                    if (objCookie.Values["Email"] == restRow["Email"].ToString())
                    {
                        txtEmail.Text = restRow["Email"].ToString();
                        txtContact.Text = restRow["Contact_Email"].ToString();
                        //add image option
                        txtPhone.Text = restRow["Phone_Number"].ToString();
                        txtAddress.Text = restRow["Address"].ToString();
                        txtCity.Text = restRow["City"].ToString();
                        txtState.Text = restRow["State"].ToString();
                        txtZip.Text = restRow["ZipCode"].ToString();
                        txtRestType.Text = restRow["RestaurantType"].ToString();
                        txtCuisineType.Text = restRow["CuisineType"].ToString();
                        txtDescription.Text = restRow["Description"].ToString();
                        
                    }
                }
            }

            
         }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            txtEmail.ReadOnly = false;

            lblContact.Visible = true;
            txtContact.Visible = true;
            txtContact.ReadOnly = false;

            lblPhone.Visible = true;
            txtPhone.Visible = true;
            txtPhone.ReadOnly = false;

            lblAddress.Visible = true;
            txtAddress.Visible = true;
            txtAddress.ReadOnly = false;

            lblCity.Visible = true;
            txtCity.Visible = true;
            txtCity.ReadOnly = false;

            //fix
            lblState.Visible = true;
            ddlState.Visible = true;
            txtState.Visible = false;


            lblZip.Visible = true;
            txtZip.Visible = true;
            txtZip.ReadOnly = false;

            //fix
            lblRestType.Visible = true;
            ddlRestType.Visible = true;
            txtRestType.Visible = false;
            //fix
            lblCuisineType.Visible = true;
            ddlCuisineType.Visible = true;
            txtCuisineType.Visible = false;

            lblDescription.Visible = true;
            txtDescription.Visible = true;
            txtDescription.ReadOnly = false;

            lblNewPw.Visible = false;
            txtNewPw.Visible = false;

            btnPwCancel.Visible = false;
            btnUpdatePw.Visible = false;

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM TP_Restaurants";
            DataSet restData = dbConnect.GetDataSet(sql);
            DataTable restTable = restData.Tables[0];
            HttpCookie objCookie = Request.Cookies["theCookie"];

            for (int row = 0; row < restTable.Rows.Count; row++)
            {
                DataRow restRow = restTable.Rows[row];
                if (objCookie.Values["Email"] == restRow["Email"].ToString())
                {
                    txtEmail.Text = restRow["Email"].ToString();
                    txtContact.Text = restRow["Contact_Email"].ToString();
                    //add image option
                    txtPhone.Text = restRow["Phone_Number"].ToString();
                    txtAddress.Text = restRow["Address"].ToString();
                    txtCity.Text = restRow["City"].ToString();
                    txtState.Text = restRow["State"].ToString();
                    txtZip.Text = restRow["ZipCode"].ToString();
                    txtRestType.Text = restRow["RestaurantType"].ToString();
                    txtCuisineType.Text = restRow["CuisineType"].ToString();
                    txtDescription.Text = restRow["Description"].ToString();

                    txtEmail.ReadOnly = true;
                    txtContact.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtCity.ReadOnly = true;
                    txtState.ReadOnly = true;
                    txtZip.ReadOnly = true;
                    txtRestType.ReadOnly = true;
                    txtCuisineType.ReadOnly = true;
                    txtDescription.ReadOnly = true;

                }
            }
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_UpdateProfile";

            objCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            objCommand.Parameters.AddWithValue("@contact_email", txtContact.Text);
            objCommand.Parameters.AddWithValue("@phone", txtPhone.Text);
            objCommand.Parameters.AddWithValue("@address", txtAddress.Text);
            objCommand.Parameters.AddWithValue("@city", txtCity.Text);
            objCommand.Parameters.AddWithValue("@state", ddlState.Text);
            objCommand.Parameters.AddWithValue("@zip", txtZip.Text);
            objCommand.Parameters.AddWithValue("@restType", txtRestType.Text);
            objCommand.Parameters.AddWithValue("@cuisineType", ddlCuisineType.Text);
            objCommand.Parameters.AddWithValue("@description", txtDescription.Text);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            Response.Write("Your Acc Profile has been updated");

            string sql = "SELECT * FROM TP_Restaurants";
            DataSet restData = dbConnect.GetDataSet(sql);
            DataTable restTable = restData.Tables[0];
            HttpCookie objCookie = Request.Cookies["theCookie"];

            for (int row = 0; row < restTable.Rows.Count; row++)
            {
                DataRow restRow = restTable.Rows[row];
                if (objCookie.Values["Email"] == restRow["Email"].ToString())
                {
                    txtEmail.Text = restRow["Email"].ToString();
                    txtContact.Text = restRow["Contact_Email"].ToString();
                    //add image option
                    txtPhone.Text = restRow["Phone_Number"].ToString();
                    txtAddress.Text = restRow["Address"].ToString();
                    txtCity.Text = restRow["City"].ToString();
                    txtState.Text = restRow["State"].ToString();
                    txtZip.Text = restRow["ZipCode"].ToString();
                    txtRestType.Text = restRow["RestaurantType"].ToString();
                    txtCuisineType.Text = restRow["CuisineType"].ToString();
                    txtDescription.Text = restRow["Description"].ToString();

                    txtEmail.ReadOnly = true;
                    txtContact.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtCity.ReadOnly = true;
                    txtState.ReadOnly = true;
                    txtZip.ReadOnly = true;
                    txtRestType.ReadOnly = true;
                    txtCuisineType.ReadOnly = true;
                    txtDescription.ReadOnly = true;

                }
            }



        }

        protected void btnChangePw_Click(object sender, EventArgs e)
        {
            lblNewPw.Visible = true;
            txtNewPw.Visible = true;

            btnPwCancel.Visible = true;
            btnUpdatePw.Visible = true;


            btnCancel.Visible = false;
            btnUpdate.Visible = false;
            lblEmail.Visible = false;
            txtEmail.Visible = false;
            txtEmail.ReadOnly = true;

            lblContact.Visible = false;
            txtContact.Visible = false;
            txtContact.ReadOnly = true;

            lblPhone.Visible = false;
            txtPhone.Visible = false;
            txtPhone.ReadOnly = true;

            lblAddress.Visible = false;
            txtAddress.Visible = false;
            txtAddress.ReadOnly = false;

            lblCity.Visible = false;
            txtCity.Visible = false;
            txtCity.ReadOnly = true;

            //fix
            lblState.Visible = false;
            ddlState.Visible = false;
            txtState.Visible = false;


            lblZip.Visible = false;
            txtZip.Visible = false;
            txtZip.ReadOnly = true;

            //fix
            lblRestType.Visible = false;
            ddlRestType.Visible = false;
            txtRestType.Visible = false;
            //fix
            lblCuisineType.Visible = false;
            ddlCuisineType.Visible = false;
            txtCuisineType.Visible = false;

            lblDescription.Visible = false;
            txtDescription.Visible = false;
            txtDescription.ReadOnly = true;
        }

        protected void btnPwCancel_Click(object sender, EventArgs e)
        {
            //change pw controls
            lblNewPw.Visible = false;
            txtNewPw.Visible = false;

            btnPwCancel.Visible = false;
            btnUpdatePw.Visible = false;

            //edit info controls
            btnCancel.Visible = true;
            btnUpdate.Visible = true;
            lblEmail.Visible = true;
            txtEmail.Visible = true;
            txtEmail.ReadOnly = true;

            lblContact.Visible = true;
            txtContact.Visible = true;
            txtContact.ReadOnly = true;

            lblPhone.Visible = true;
            txtPhone.Visible = true;
            txtPhone.ReadOnly = true;

            lblAddress.Visible = true;
            txtAddress.Visible = true;
            txtAddress.ReadOnly = true;

            lblCity.Visible = true;
            txtCity.Visible = true;
            txtCity.ReadOnly = true;

            //fix
            lblState.Visible = true;
            ddlState.Visible = false;
            txtState.Visible = true;


            lblZip.Visible = true;
            txtZip.Visible = true;
            txtZip.ReadOnly = true;

            //fix
            lblRestType.Visible = true;
            ddlRestType.Visible = false;
            txtRestType.Visible = true;
            //fix
            lblCuisineType.Visible = true;
            ddlCuisineType.Visible = false;
            txtCuisineType.Visible = true;

            lblDescription.Visible = true;
            txtDescription.Visible = true;
            txtDescription.ReadOnly = true;
        }

        protected void btnUpdatePw_Click(object sender, EventArgs e)
        {
            HttpCookie objCookie = Request.Cookies["theCookie"];
            int restID = Convert.ToInt32(objCookie.Values["restId"]);

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "TP_ChangeRestPassword";

            objCommand.Parameters.AddWithValue("@password", txtNewPw.Text);
            objCommand.Parameters.AddWithValue("@restId", restID);

            dbConnect.DoUpdateUsingCmdObj(objCommand);

            Response.Write("Your password has been changed");
        }
    }
}