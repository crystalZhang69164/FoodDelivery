using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;


namespace Utilities
{
    public class VirtualWallet
    {
        int walletID;
        string name;
        double balance;
        string cardNumber;
        string apiKey;
        int merchantAccID;
        DBConnect dbConnect = new DBConnect();
        


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ApiKey
        {
            get { return apiKey; }
            set { apiKey = value; }
        }
        public int MerchantAccID
        {
            get { return merchantAccID; }
            set { merchantAccID = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public int WalletID
        {
            get { return walletID; }
            set { walletID = value; }
        }

        public string CardNumber
        {
            get { return cardNumber; }
            set { cardNumber = value; }
        }
        
        public int CreateWallet()
        {
            SqlCommand objCommand = new SqlCommand();
            int walletID = 0;




            //store procedure
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "";

            //objCommand.Parameters.AddWithValue("");

            int retVal = dbConnect.DoUpdateUsingCmdObj(objCommand);
            return retVal;
        }

        public void UpdateWallet()
        {

        }


    }
}
