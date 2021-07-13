using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using bd2_trabalho_final.Database;

namespace bd2_trabalho_final.Services
{
    static class LoginService
    {
        public static int IsValidLogin(string username, string password)
        {
            int idUser = 0;

            DatabaseUtils.ExecuteSqlCommand("SYSTEM_LOGIN", (sqlConnection, sqlCommand) => 
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@username", username);
                sqlCommand.Parameters.AddWithValue("@password", password);

                SqlParameter returnParameter = sqlCommand.Parameters.Add("@return", SqlDbType.Bit);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
                idUser = Convert.ToInt32(returnParameter.Value);
            });

            return idUser;
        }
    }
}
