using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace Collections
{

    public class Program
    {
        public enum CrudOptions // Enum for CRUD operations
        {
            create,
            readAll,
            readById,
            update,
            delete
        }

        public static void Crud(CrudOptions crudOptions, ProductActions productActions) // Method to perform CRUD operations
        {
            switch (crudOptions) // Switch statement for CRUD operations
            {
                case CrudOptions.create: // Create operation
                    DoCreate(productActions); // Call the method to create
                    break;
                case CrudOptions.readAll: // Read operation
                    DoReadAll(productActions); // Call the method to read
                    break;
                case CrudOptions.readById:
                    DoReadById(productActions);
                    break;
                case CrudOptions.update: // Update operation
                    DoUpdate(productActions); // Call the method to update
                    break;
                case CrudOptions.delete: // Delete operation
                    DoDelete(productActions); // Call the method to delete
                    break;
            }
        }

        static void Main(string[] args)
        {
            ProductModel productModel = new ProductModel();
            
            ProductActions productActions = new ProductActions();
            bool continueCrud = true; // Boolean variable to control the CRUD loop
            while (continueCrud) // Loop for CRUD operations
            {
                Console.WriteLine("\nChoose your method:\n 1.Add \n 2.ReadAll \n 3.ReadById \n 4.Update \n 5.Delete \n 6.Quit \n");

                int num = Convert.ToInt32(Console.ReadLine()); // Reading user choice
                switch (num) // Switch statement for user choice
                {
                    case 1: // Create operation
                        Crud(CrudOptions.create, productActions); // Call the CRUD method with create option
                        break;
                    case 2: // Read operation
                        Crud(CrudOptions.readAll, productActions); // Call the CRUD method with read option
                        break;
                    case 3: //Read by Id Operation
                        Crud(CrudOptions.readById, productActions);
                        break;

                    case 4: // Update operation
                        Crud(CrudOptions.update, productActions); // Call the CRUD method with update option
                        break;
                    case 5: // Delete operation
                        Crud(CrudOptions.delete, productActions); // Call the CRUD method with delete option
                        break;
                    case 6: // Quit
                        Console.WriteLine("You have exited from the operations."); // Message for quitting
                        continueCrud = false; // Update the loop control variable to exit the loop
                        break;
                    default: // Invalid input
                        Console.WriteLine("Invalid option. Please choose again."); // Message for invalid input
                        break;
                }
            }

        }


        private static void DoCreate(ProductActions productActions)
        {
            Console.WriteLine("\nEnter the new Product details");

            Console.Write("\nProduct ID: ");
            int productId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Product Description: ");
            string productDesc = Console.ReadLine();

            Console.Write("Product Price: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Product Image: ");
            string productImage = Console.ReadLine();

            ProductModel newProduct = new ProductModel()
            {
                ProductId = productId,
                Name = productName,
                Description = productDesc,
                Price = productPrice,
                ProductImage = productImage
            };

            productActions.Create(newProduct);
            Console.WriteLine("\nNew Product added Successfully");
            Console.WriteLine();
        }
        private static void DoReadAll(ProductActions productActions) // Method to read existing products
        {
            Console.WriteLine("\nList of Products:");

            List<ProductModel> listofAllRecords = productActions.ReadAll();
            foreach (ProductModel product in listofAllRecords) // Corrected type to CarsModel
            {
                Console.WriteLine(product.ProductId + " " + product.Name + " " + product.Description + " " + product.Price + " " + product.ProductImage); // Printing car details
            }
            Console.WriteLine();
        }

        private static void DoReadById(ProductActions productActions)
        {
            Console.WriteLine("\nEnter the product ID to display product details\n");
            int productId = Convert.ToInt32(Console.ReadLine());

            ProductModel readProduct = productActions.ReadById(productId); // Capture the returned product
            if (readProduct != null)
            {
                Console.WriteLine(readProduct.ProductId + " " + readProduct.Name + " " + readProduct.Description + " " + readProduct.Price + " " + readProduct.ProductImage); // Printing product details

            }
            else
            {
                Console.WriteLine("Product not found!"); // Notify if the product is not found
            }
        }


        private static void DoUpdate(ProductActions productActions) // Method to update existing product
        {
            productActions.ReadAll();
            Console.WriteLine("\nEnter the product Id which you want to update");
            int updateById = Convert.ToInt32(Console.ReadLine()); // Reading product ID to update

            ProductModel productDetails = productActions.ReadById(updateById); // Calling update method

            Console.WriteLine("old product details for your reference: " + productDetails.ProductId + " " + productDetails.Name + " " + productDetails.Description + " " + productDetails.Price + " " + productDetails.ProductImage);
            Console.Write("\nEnter New product Name:");
            string newProductName = Console.ReadLine();
            productDetails.Name = newProductName;

            Console.Write("New product Description: ");
            string newProductDesc = Console.ReadLine();
            productDetails.Description = newProductDesc;

            Console.Write("New product Price: ");
            int newProductPrice = Convert.ToInt32((Console.ReadLine()));
            productDetails.Price = newProductPrice;

            Console.Write("New product Color: ");
            string newProductImage = Console.ReadLine();
            productDetails.ProductImage = newProductImage;

            productActions.Update(productDetails);
            if (productDetails != null) // Check if product is found
            {
                Console.WriteLine($"\nUpdated product Details:  {productDetails.Name} {productDetails.Description} {productDetails.Price} {productDetails.ProductImage}"); // Printing updated car details
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("product with the specified ID was not found."); // Message if product not found
            }
        }

        private static void DoDelete(ProductActions productActions) // Method to delete existing product
        {
            productActions.ReadAll(); // Call read method to display existing products
            Console.WriteLine("\nEnter the product Id which you want to delete");
            int deleteId = Convert.ToInt32(Console.ReadLine()); // Reading product ID to delete

            productActions.Delete(deleteId); // Calling delete method
            Console.WriteLine("Record deleted successfully"); // Message for successful deletion
            Console.WriteLine(); // Empty line
        }


    }
}
