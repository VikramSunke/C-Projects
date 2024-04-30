using System.Data;
using System.Data.SqlClient;

namespace SQLDemo
{
    public class CarsActions
    {
        private SqlDataAdapter dataAdapter;
        private SqlConnection con;
        private SqlCommandBuilder cmdBuilder;

        private readonly string conStr = "Data Source=QUAL-LT87PXQL3\\SQLEXPRESS;Initial Catalog=CarsDB;Integrated Security=True";

        public CarsActions()
        {
            con = new SqlConnection(conStr);
            dataAdapter = new SqlDataAdapter();
            cmdBuilder = new SqlCommandBuilder(dataAdapter);
        }
        DataSet dataSet=new DataSet();
        DataTable dt = new DataTable();
        public int Add(CarsModel car)
        {
            try
            {
                con.Open();
                dataAdapter.SelectCommand = new SqlCommand("Select * from CarsTable",con);
                dataAdapter.Fill(dataSet);

                DataRow newRow = dataSet.Tables[0].NewRow();
                newRow[0] = car.id;
                newRow[1] = car.carName;
                newRow[2] = car.carPrice;
                newRow[3] = car.carColor;
                dataSet.Tables[0].Rows.Add(newRow);
                cmdBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.InsertCommand = cmdBuilder.GetInsertCommand();
                return dataAdapter.Update(dataSet);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1;
            }
            finally
            {
                 con.Close();
            }
        }


        public int Update(CarsModel car)
        {
            try
            {
                con.Open();
                dataAdapter = new SqlDataAdapter($"SELECT * FROM CarsTable WHERE id = {car.id}", con);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter); // This line adds necessary commands to the DataAdapter
                dataAdapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("No record found with the specified ID.");
                    return 0; // Return 0 to indicate no update
                }

                DataRow rowToUpdate = dt.Rows[0];
                rowToUpdate[1] = car.carName; // Assuming "carName" is the column name
                rowToUpdate[2] = car.carPrice; // Assuming "carPrice" is the column name
                rowToUpdate[3] = car.carColor; // Assuming "carColor" is the column name

                return dataAdapter.Update(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1; // Return -1 to indicate failure
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }


        public int Delete(int id)
        {
            try
            {
                con.Open();
                dataAdapter= new SqlDataAdapter($"SELECT * FROM CarsTable WHERE id = {id}", con);
                dataAdapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    Console.WriteLine("No record found with the specified ID.");
                    return 0; // Return 0 to indicate no deletion
                }

                dt.Rows[0].Delete();
                return dataAdapter.Update(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return -1; // Return -1 to indicate failure
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        public DataTable ReadAll()
        {
            dataAdapter = new SqlDataAdapter("SELECT * FROM CarsTable", con);
            try
            {
                con.Open();
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return dt;
        }

        public DataTable ReadById(int id)
        {
            dataAdapter = new SqlDataAdapter($"SELECT * FROM CarsTable WHERE id = {id}", con);
            //SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
            try
            {
                con.Open();
                dataAdapter.Fill(dt);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            return dt;
        }
    }
}