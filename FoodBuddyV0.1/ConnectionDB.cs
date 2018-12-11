using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FoodBuddyV0._1
{
    class ConnectionDB
    {
        static public MySqlConnection databaseConnection;
        public ConnectionDB()
        {
            string SQLConnectionString = "Server= den1.mysql4.gear.host;port=3306;Uid=proftaakp2;Database=ProftaakP2;Pwd=Ky53XL2-m_38;";
            databaseConnection = new MySqlConnection(SQLConnectionString);
            databaseConnection.Close();
        }
    }
}
