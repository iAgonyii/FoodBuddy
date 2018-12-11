using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FoodBuddyV0._1
{
    class DatabaseCommands
    {
        public string GetDataName(string scannedproduct)
        {
            ConnectionDB.databaseConnection.Close();
            ConnectionDB.databaseConnection.Open();
            string sql = $" SELECT * FROM producten WHERE Barcode = '{scannedproduct}'";
            MySqlCommand commandDatabase = new MySqlCommand(sql, ConnectionDB.databaseConnection);
            try
            {
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetString("Naam");
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
             return "Database fout";
        }


        public string GetDataIngredients(string scannedproduct)
        {
            ConnectionDB.databaseConnection.Close();
            ConnectionDB.databaseConnection.Open();
            string sql = $" SELECT * FROM ingrediënten WHERE Barcode = '{scannedproduct}'";
            MySqlCommand commandDatabase = new MySqlCommand(sql, ConnectionDB.databaseConnection);
            try
            {
                MySqlDataReader reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                    return reader.GetString("Ingrediënten");
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return "Database fout";
        }






    }
}
