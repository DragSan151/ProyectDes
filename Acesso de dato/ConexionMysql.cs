using System.Data.SqlClient;

namespace Acesso_de_dato
{
    public abstract class ConexionMysql
    {
        private readonly string connectionString;
        public ConexionMysql()
        {
            connectionString = "Server=localhost;DataBase= proyect; integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

       
    }
}