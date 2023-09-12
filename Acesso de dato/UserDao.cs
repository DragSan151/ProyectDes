using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_de_Soporte.Cache;


namespace Acesso_de_dato
{
    public class UserDao : ConexionMysql
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from usuario where nombre=@user and password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            CacheLogin.Id = reader.GetInt32(0);
                            CacheLogin.nombre = reader.GetString(1);
                            CacheLogin.Password = reader.GetString(2);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);
                        var Servicio_de_Email = new Servicio_de_Email.Soporte();
                        Servicio_de_Email.sendMail(
                          subject: "SYSTEM: Solicitud de recuperación de contraseña",
                          body: "Hola, " + userName + "\nUsted solicitó recuperar su contraseña.\n" +
                          "tu contraseña actual es: " + accountPassword +
                          "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nUsted solicitó recuperar su contraseña.\n" +
                          "Porfavor chequea tu email: " + userMail +
                          "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";

                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con ese correo o nombre de usuario";
                }
            }
        }
        public void AnyMethod()
        {
            if (CacheLogin.Tipo == Posicion.Administrativo)
            {
                //Lineas o métodos que quieras ejecutar para el cargo recepcionita
            }
            if (CacheLogin.Tipo == Posicion.Productor)
            {
                //Lineas o métodos que quieras ejecutar para el cargo contador
            }
        }
    }
}

               