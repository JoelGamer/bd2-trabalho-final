using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using bd2_trabalho_final.Classes;
using bd2_trabalho_final.Database;
using bd2_trabalho_final.Enums;
using bd2_trabalho_final.Utilities;

namespace bd2_trabalho_final.Services
{
    static class ProductService
    {
        public static DataTable GetDataTableProductsCategories()
        {
            DataTable dataTable = new DataTable();
            string command = "SELECT * FROM PRODUCT_CATEGORY";

            DatabaseUtils.ExecuteSqlCommandWithDataTable(command, (sqlConnection, sqlCommand, genDataTable) =>
            {
                sqlConnection.Open();
                dataTable = genDataTable;
            });

            return dataTable;
        }

        public static void CreateProductCategory(ProductCategory productCategory)
        {
            DatabaseUtils.ExecuteSqlCommand("CREATE_PRODUCT_CATEGORY", (sqlConnection, sqlCommand) =>
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@name", productCategory.Name);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }

        public static void UpdateProductCategory(ProductCategory productCategory)
        {
            DatabaseUtils.ExecuteSqlCommand("UPDATE_PRODUCT_CATEGORY", (sqlConnection, sqlCommand) =>
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", productCategory.Id);
                sqlCommand.Parameters.AddWithValue("@name", productCategory.Name);

                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }

        public static void DeleteProductCategory(ProductCategory productCategory)
        {
            DatabaseUtils.ExecuteSqlCommand($"DELETE FROM PRODUCT_CATEGORY WHERE id = {productCategory.Id}", (sqlConnection, sqlCommand) =>
            {
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            });
        }
    }
}
