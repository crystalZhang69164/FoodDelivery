using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;


namespace Utilities
{
    public class Customers
    {
        private string customerEmail;
        private string password;
        private string deliveryAddress;
        private string billingAddress;
        private string emailAddress;
        private string deliveryCity;
        private string billingCity;
        private string deliveryState;
        private string billingState;
        private string deliveryZipCode;
        private string billingZipCode;

        public string CustomerEmail
        {
            get { return customerEmail; }
            set { customerEmail = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string DeliveryAddress
        {
            get { return deliveryAddress; }
            set { deliveryAddress = value; }
        }
        public string BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }
        }
        public string EmailAddress
        {
            get { return emailAddress; }
            set { emailAddress = value; }
        }
        public string DeliveryCity
        {
            get { return deliveryCity; }
            set { deliveryCity = value; }
        }
        public string BillingCity
        {
            get { return billingCity; }
            set { billingCity = value; }
        }
        public string DeliveryState
        {
            get { return deliveryState; }
            set { deliveryState = value; }
        }
        public string BillingState
        {
            get { return billingState; }
            set { billingState = value; }
        }
        public string DeliveryZipCode
        {
            get { return deliveryZipCode; }
            set { deliveryZipCode = value; }
        }
        public string BillingZipCode
        {
            get { return billingZipCode; }
            set { billingZipCode = value; }

        }
    }
}
