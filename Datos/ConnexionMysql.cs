using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Windows;


namespace Datos
{
    public abstract class ConnexionMysql
    {

        MySqlConnection conexion = new MySqlConnection();

        static string servidor = "localhost";
        static string base_de_datos = "proyect";
        static string usuario = "seba";
        static string password = "58603905";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "databases=" + base_de_datos + ";";
        
        public MySqlConnection establecerConexion()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                MessageBox.Show("Se logro conectarse a la base de datos");
            }
        }

    }
}