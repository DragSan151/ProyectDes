using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
   public class UsuarioDatos : ConnexionMysql
    {
        public bool Login(string user, string cedula)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuarios where LoginName=@user and Cedula=@cedula";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@cedula", cedula);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                           // UserCache.IdUser = reader.GetInt32(0);
                           // UserCache.LoginName = reader.GetString(1);
                           // UserCache.Password = reader.GetString(2);
                           // UserCache.FirstName = reader.GetString(3);
                           // UserCache.LastName = reader.GetString(4);
                           // UserCache.Position = reader.GetString(5);
                           // UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
