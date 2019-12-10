using System.Data;
using System.Data.SqlClient;

namespace WebApiCrm.Models.Auxiliar
{
    public static class FactoryConnection
    {
        public static SqlConnection connection => new SqlConnection(new SqlConnectionStringBuilder()
        {
            DataSource = XConfig.DataSource,
            InitialCatalog = XConfig.InitialCatalog,
            UserID = XConfig.UserID,
            Password = XConfig.Password
        }.ConnectionString);

        public static SqlCommand NewCommand()
        {
            var command = connection.CreateCommand();

            if (command.Connection.State == ConnectionState.Closed)
            {
                command.Connection.Open();
                return command;
            }
            return command;
        }

        public static void Liberar()
        {
            connection.Close();
        }
    }
}