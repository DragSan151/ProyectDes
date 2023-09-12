using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acesso_de_dato.Servicio_de_Email
{
     class Soporte : MasterEmailServiviod
    {
        public Soporte()
        {
            senderMail = "soporteSystemTiendita@gmail.com";
            password = "admin4321";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
}
