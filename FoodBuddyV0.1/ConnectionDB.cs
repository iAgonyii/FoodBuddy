using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proftaak_P2_V1
{
    class ConnectionDB
    {
        public ConnectionDB()
        {
            MySqlConnection databaseConnection;
            string SQLConnectionString = "Server= den1.mysql4.gear.host;port=3306;Uid=proftaakp2;Database=ProftaakP2;Pwd=Ky53XL2-m_38;";
            databaseConnection = new MySqlConnection(SQLConnectionString);
            databaseConnection.Close();
        }
    }
}
