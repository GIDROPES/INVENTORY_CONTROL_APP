using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;


namespace INVENTORY_CONTROL_APP
{
    class DAL
    {
        static string connectionStr = @"Data Source=LAPTOP-UTA4M5MF;
                Initial Catalog = INVENTORY_CONTROL; Integrated Security = True"; //-------строка соединения-----


        public ArrayList getAllProductsFromStore(int storeCode)
        {
            ArrayList allProducts = new ArrayList();


            SqlConnection con = new SqlConnection(connectionStr);
            String commandStr = String.Format( "SELECT * FROM PRODUCT_STORE WHERE ID_STORAGE = {0}", storeCode );
            SqlCommand command = new SqlCommand(commandStr, con);
            
            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
                foreach (DbDataRecord result in reader)
                    allProducts.Add(result);
            else
                return null;

            con.Close();
            return allProducts;
            
        }
        
        public List<String> getAllStores()
        {
            List<String> allStores = new List<string>();
            SqlConnection con = new SqlConnection(connectionStr);
            String commandStr = "SELECT STORE_NAME FROM STORES";
            SqlCommand command = new SqlCommand(commandStr, con);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                allStores.Add(reader.GetString(0));
            }

            con.Close();
            return allStores;
        }

    }
}
