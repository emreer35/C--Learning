using System;
using System.Data;
using System.Data.SqlClient;

namespace ADONet;

public class ProductDal
{
    public DataTable GetAll()
    {
        SqlConnection connection = new SqlConnection(@"Server=localhost,8080;Database=ETrade;User Id=sa;Password=123123qwe-*.;Encrypt=True;TrustServerCertificate=True");
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
        SqlCommand command = new SqlCommand("Select * From Products");

        SqlDataReader reader = command.ExecuteReader();
        DataTable dataTable = new DataTable();
        dataTable.Load(reader);
        reader.Close();
        connection.Close();
        return dataTable;
    }
}
