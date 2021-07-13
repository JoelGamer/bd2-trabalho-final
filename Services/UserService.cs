using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using bd2_trabalho_final.Classes.Persons;
using bd2_trabalho_final.Classes.Persons.Users;
using bd2_trabalho_final.Database;
using bd2_trabalho_final.Enums;
using bd2_trabalho_final.Utilities;

namespace bd2_trabalho_final.Services
{
    static class UserService
    {
        public static User GetUser(int idUser)
        {
            User user = null;
            string command = $"SELECT * FROM USER_INFO WHERE id_user = {idUser}";

            DatabaseUtils.ExecuteSqlCommand(command, (sqlConnection, sqlCommand) =>
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (!sqlDataReader.HasRows) return;

                sqlDataReader.Read();

                Person person = new Person(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                user = new User(sqlDataReader.GetInt32(2), person, (UserType)sqlDataReader.GetInt32(3));
            });

            if (!ClassEmpty.Validate(user)) throw new Exception($"No user found with id_user: {idUser}");
            return user;
        }

        public static Client GetClient(int idUser)
        {
            Client client = null;
            string command = $"SELECT * FROM CLIENT_INFO WHERE id_user = {idUser}";

            DatabaseUtils.ExecuteSqlCommand(command, (sqlConnection, sqlCommand) =>
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (!sqlDataReader.HasRows) return;

                sqlDataReader.Read();

                Person person = new Person(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                User user = new User(sqlDataReader.GetInt32(2), person, (UserType)sqlDataReader.GetInt32(3));
                client = new Client(sqlDataReader.GetInt32(4), user, sqlDataReader.GetInt64(5));
            });

            if (!ClassEmpty.Validate(client)) throw new Exception($"No client found with id_user: {idUser}");
            return client;
        }

        public static DataTable GetDataTableOperators()
        {
            DataTable dataTable = new DataTable();
            string command = "SELECT * FROM OPERATOR_INFO";

            DatabaseUtils.ExecuteSqlCommandWithDataTable(command, (sqlConnection, sqlCommand, genDataTable) =>
            {
                sqlConnection.Open();
                dataTable = genDataTable;
            });


            return dataTable;
        }

        public static DataTable GetDataTableOperatorsHumanized()
        {
            DataTable dataTable = new DataTable();
            string command = "SELECT * FROM OPERATOR_INFO_HUMANIZED";

            DatabaseUtils.ExecuteSqlCommandWithDataTable(command, (sqlConnection, sqlCommand, genDataTable) =>
            {
                sqlConnection.Open();
                dataTable = genDataTable;
            });

            return dataTable;
        }

        public static List<Operator> GetOperators()
        {
            List<Operator> operators = new List<Operator>();
            string command = "SELECT * FROM OPERATOR_INFO";

            DatabaseUtils.ExecuteSqlCommand(command, (sqlConnection, sqlCommand) =>
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Person person = new Person(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                    User user = new User(sqlDataReader.GetInt32(2), person, (UserType)sqlDataReader.GetInt32(3));
                    operators.Add(new Operator(sqlDataReader.GetInt32(4), user, sqlDataReader.GetBoolean(5)));
                }
            });


            return operators;
        }

        public static Operator GetOperator(int idUser)
        {
            Operator @operator = null;
            string command = $"SELECT * FROM OPERATOR_INFO WHERE id_user = {idUser}";

            DatabaseUtils.ExecuteSqlCommand(command, (sqlConnection, sqlCommand) =>
                {
                    sqlConnection.Open();
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (!sqlDataReader.HasRows) return;

                    sqlDataReader.Read();

                    Person person = new Person(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                    User user = new User(sqlDataReader.GetInt32(2), person, (UserType)sqlDataReader.GetInt32(3));
                    @operator = new Operator(sqlDataReader.GetInt32(4), user, sqlDataReader.GetBoolean(5));
                });

            if (!ClassEmpty.Validate(@operator)) throw new Exception($"No operator found with id_user: {idUser}");
            return @operator;
        }

        public static void CreateOperator(Operator @operator)
        {
            DatabaseUtils.ExecuteSqlCommand("CREATE_OPERATOR", (sqlConnection, sqlCommand) =>
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", @operator.Name);
                sqlCommand.Parameters.AddWithValue("@username", @operator.Username);
                sqlCommand.Parameters.AddWithValue("@password", @operator.Password);
                sqlCommand.Parameters.AddWithValue("@is_administrator", @operator.IsAdministrator);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }

        public static void UpdateOperator(Operator @operator)
        {
            DatabaseUtils.ExecuteSqlCommand("UPDATE_OPERATOR", (sqlConnection, sqlCommand) =>
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", @operator.Id);
                sqlCommand.Parameters.AddWithValue("@name", @operator.Name);
                sqlCommand.Parameters.AddWithValue("@username", @operator.Username);
                sqlCommand.Parameters.AddWithValue("@password", @operator.Password);
                sqlCommand.Parameters.AddWithValue("@is_administrator", @operator.IsAdministrator);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }

        public static void DeleteOperator(Operator @operator)
        {
            DatabaseUtils.ExecuteSqlCommand($"DELETE FROM OPERATOR WHERE id = {@operator.Id}", (sqlConnection, sqlCommand) =>
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }
    }
}
