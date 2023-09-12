using Acesso_de_dato;
using Capa_de_Soporte.Cache;
namespace Domain
{
    public class ModeloUsuario
    {
        UserDao userDao = new UserDao();
        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);
        }
        public void anyMethod()
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