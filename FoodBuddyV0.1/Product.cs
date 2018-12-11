using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBuddyV0._1
{
    class Product
    {
        private string productID;

        public Product (string scannedproduct)
        {
            this.productID = scannedproduct;
        }

        public string GetProductName()
        {
            DatabaseCommands newCommand = new DatabaseCommands();
            string productName = newCommand.GetDataName(productID);
            return productName;
        }

        public string GetProductIngredients()
        {
            DatabaseCommands newCommand = new DatabaseCommands();
            string productIngedrients = newCommand.GetDataIngredients(productID);
            return productIngedrients;
        }


    }
}
