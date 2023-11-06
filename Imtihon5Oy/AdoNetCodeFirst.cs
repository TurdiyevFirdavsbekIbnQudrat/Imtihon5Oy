using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class AdoNetCodeFirst
    {
        private string connectionString = "server=DESKTOP-HUHB6EP;database=Birinchi_ish;Trusted_Connection=true";
        public void AdoNet()
        {
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "select * from IdIsm";
                SqlCommand sqlCommand = new SqlCommand(query,connection);
                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + " "+ reader[1]);
                    }
                }

            }
        }
    }
}
