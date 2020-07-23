using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Restaurants
    {
        private string restaurantEmail;
        private string image;
        private string password;
        private string contactEmail;
        private string phoneNumber;
        private string address;
        private string city;
        private string zipCode;
        private string state;
        private string restaurantType;
        private string cuisineType;
        private string description;
        private string name;


        public string RestaurantEmail
        {
            get { return restaurantEmail; }
            set { restaurantEmail = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string ContactEmail
        {
            get { return contactEmail; }
            set { contactEmail = value; }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string RestaurantType
        {
            get { return restaurantType; }
            set { restaurantType = value; }
        }
        public string CuisineType
        {
            get { return cuisineType; }
            set { cuisineType = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }


    }
}
