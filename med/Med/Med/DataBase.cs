using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med
{
    internal class DataBase
    {
        private SqlConnection sqlConnection;
        public DataBase()
        {
            string relativePath = @"..\..\..\Database.mdf";
            string absolutePath = Path.GetFullPath(relativePath);
            string connectionString = string.Format(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={0};Integrated Security=True", absolutePath);

            sqlConnection = new SqlConnection(connectionString);
        }

        public void openConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
