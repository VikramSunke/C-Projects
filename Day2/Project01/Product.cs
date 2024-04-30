using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/* Day2 is my solution name 
 * Project01 is my first project
 * Product.cs is my class name, here, i've declared fields properties and methods
*/
namespace Project01  //Project name
{
    internal class Product  // product class name
    {
        //declaring fields
        private string pName;  // In short I'm using product as p  [ pName = productName]
        private string pDescription;
        private string pColor;
        private int pPrice;

        //declaring properties

        public string PName         //In short i'm using product as P [PName = Product_Name]{
        {
            get { return pName; }                // This part lets us read the number stored in pName.
            set { pName = value; }                      // This part lets us change the number stored in pName.
        }
        public string PDescription
        {
            get { return pDescription; }
            set { pDescription = value; }
        }
        public string PColor
        {
            get { return pColor; }
            set { pColor = value; }
        }
        public int PPrice
        {
            get { return pPrice; }
            set { pPrice = value; }
        }

        //methods
        // This method sets the information (name, description, color, and price) of a product.

        public void ProductInformation( string pName, string pDescription, string pColor, int pPrice)
        {
            PName = pName;
            PDescription = pDescription;
            PColor = pColor;
            PPrice = pPrice;
        }

        // This method generates and returns a string containing the details of a product.

        public string AddProductDetails()
        {
            // Create a string builder to efficiently build a string.
            StringBuilder sb = new StringBuilder();

            // Add the product name to the string using string interpolation, then move to a new line using Environment.NewLine.
            sb.Append($"Product Name = {PName}{Environment.NewLine}");

            // Add the product description to the string using string interpolation, then move to a new line with the newline escape sequence '\n'.
            sb.AppendFormat($"Product Description = {PDescription}\n");

            // Add the product color to the string using string interpolation, then move to a new line with the AppendLine method.
            sb.AppendLine($"Product Color = {PColor}");

            // Add the product price to the string using composite formatting, then move to a new line using Environment.NewLine.
            sb.AppendFormat("Product Price = {0}{1}", pPrice, Environment.NewLine); 

            return sb.ToString();   
        }



    }
}
