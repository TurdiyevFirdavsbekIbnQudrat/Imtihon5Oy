using Dapper;
using Imtihon5Oy.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imtihon5Oy
{
    public class Dapperda
    {
        private string connectionString = "server=DESKTOP-HUHB6EP;database=Birinchi_ish;Trusted_Connection=true";

        public async void dapperda()
        { 
            SqlConnection con = new SqlConnection(connectionString);
            await con.OpenAsync();
            string query = "select * from IdIsm";
            var idism = await con.QueryAsync<IdIsm>(query);
            foreach(var idm in idism)
            {
               Console.WriteLine(idm.id + " " +idm.name);
            }
            con.Close();
        }
    }
}
