using System;
using System.Data;
using System.Data.SqlClient;

namespace SQLDemo
{

    public class crudMethods
    {
        private CarsActions carsActions = new CarsActions();
        CarsModel car = new CarsModel();

        public void DoAdd()
        {
            
            Console.WriteLine("Enter the car ID:");
            car.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the car model:");
            car.carName = Console.ReadLine();

            Console.WriteLine("Enter the car price:");
            car.carPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the car color:");
            car.carColor = Console.ReadLine();

            int result = carsActions.Add(car);

            Console.WriteLine($"{result} record added successfully");
        }

        public void DoUpdate()
        {
            Console.WriteLine("Enter the car ID which you want to update:");
            int id = Convert.ToInt32(Console.ReadLine());
            DataTable dt = carsActions.ReadById(id);
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("\nCurrent car details: ");
                Console.WriteLine($"\ncar Id : {row[0].ToString()}");
                Console.WriteLine($"car Name : {row[1].ToString()}");
                Console.WriteLine($"car Price : {row[2].ToString()}");
                Console.WriteLine($"car Color : {row[3].ToString()}");
            }
            Console.WriteLine("Enter the new car model:");
            car.carName = Console.ReadLine();

            Console.WriteLine("Enter the new car price:");
            car.carPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the new car color:");
            car.carColor = Console.ReadLine();

            int result = carsActions.Update(car);

            if (result > 0)
                Console.WriteLine($"{result} record updated successfully");
            else if (result == 0)
                Console.WriteLine("No record found with the specified ID.");
            else
                Console.WriteLine("Update operation failed");
        }

        public void DoDelete()
        {
            Console.WriteLine("Enter the car ID which you want to delete:");
            int id = Convert.ToInt32(Console.ReadLine());

            int result = carsActions.Delete(id);

            if (result > 0)
                Console.WriteLine($"{result} record deleted successfully");
            else if (result == 0)
                Console.WriteLine("No record found with the specified ID.");
            else
                Console.WriteLine("Delete operation failed");
        }

        public void DoReadAll()
        {
            DataTable dt = carsActions.ReadAll();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"\ncar Id : {row[0].ToString()}");
                Console.WriteLine($"car Name : {row[1].ToString()}");
                Console.WriteLine($"car Price : {row[2].ToString()}");
                Console.WriteLine($"car Color : {row[3].ToString()}");
            }
        }

        public void DoReadById()
        {
            Console.WriteLine("Enter the car ID which you want to retrieve:");
            int id = Convert.ToInt32(Console.ReadLine());

            DataTable dt = carsActions.ReadById(id);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                Console.WriteLine($"\ncar Id : {row["id"].ToString()}");
                Console.WriteLine($"car Name : {row["carName"].ToString()}");
                Console.WriteLine($"car Price : {row["carPrice"].ToString()}");
                Console.WriteLine($"car Color : {row["carColor"].ToString()}");
            }
            else
            {
                Console.WriteLine("No car records found.");
            }
        }
    }
}


//        public void DoReadAll()
//        {
//            DataSet dataSet;
//            dataSet = carsActions.ReadAll();
//            foreach (DataRow row in dataSet.Tables[0].Rows)
//            {
//                Console.WriteLine($"\ncar Id : {row[0].ToString()}");
//                Console.WriteLine($"car Name : {row[1].ToString()}");
//                Console.WriteLine($"car Price : {row[2].ToString()}");
//                Console.WriteLine($"car Color : {row[3].ToString()}");

//            }
//        }
//        public void ReadById()
//        {

//            Console.WriteLine("Enter the car ID which you want to retrieve:");
//            int carId = Convert.ToInt32(Console.ReadLine());
//            DataSet dataSet = carsActions.ReadById(carId);

//            //SqlDataReader dataReader = carsActions.ReadById(carId);
//            if (dataSet.Tables[0].Rows.Count > 0)
//            {
//                DataRow row = dataSet.Tables[0].Rows[0];
//                Console.WriteLine($"\ncar Id : {row[0].ToString()}");
//                Console.WriteLine($"car Name : {row[1].ToString()}");
//                Console.WriteLine($"car Price : {row[2].ToString()}");
//                Console.WriteLine($"car Color : {row[3].ToString()}");
//            }
//            else
//            {
//                Console.WriteLine("No car records found in the dataset.");
//            }
//        }
//    }
//}


