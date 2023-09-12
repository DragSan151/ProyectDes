using Datos;
namespace Dominio
{
    public class ModeloUsuario
    {
        UsuarioDatos usuarioDatos = new UsuarioDatos();
        public bool LoginUser(string user, string cedula)
        {
            return usuarioDatos.Login(user, cedula);
        }
    }
}