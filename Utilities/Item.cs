using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class Item
    {
        private string name;
        private string description;
        private double price;
        private string imageURL;
        private string category;
        private int qty;
        private int restID;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        //checks this
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public int Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public int RestID
        {
            get { return restID; }
            set { restID = value; }
        }
    }
}
