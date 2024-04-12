using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace desafio2
{
   public class Notificacion
    {
        public string De { get; set; }
        public string Mensaje { get; set; }
        public Notificacion(string de, string mensaje)
        { 
            De = de;
            Mensaje = mensaje;
        }
    }

    public class Email : Notificacion , INotificacion
    { 
        public Email (string correo, string de, string asunto,string mensaje) : base(de,mensaje)
        {
            Correo = correo;
            Asunto = asunto;
        }
        public string Correo { get; set; }
        public string Asunto { get; set; }
        public void notifica()
        {
            Console.WriteLine("Tienes una  notificacion nueva de: " +De);
            NotificacionEmail();

        }
        public void NotificacionEmail()
        {
     
            Console.WriteLine($"Correo : {Correo}");
            Console.WriteLine($"Asunto : {Asunto}");
            Console.WriteLine($"Mensaje : {Mensaje}");
        }
    }

    public class whats : Notificacion, INotificacion
    {   
      public whats (string de, string mensaje, int numeroDeTelefono) : base(de, mensaje)
        {
            NumeroDeTelefono = numeroDeTelefono;
                
        }

      private int NumeroDeTelefono { get; set; }
        public void notifica()
        {
            Console.WriteLine("Tienes una notificacion nueva de: "+ De);
            NotificacionWhatsap();

        }
        public void NotificacionWhatsap()
        {
           
            Console.WriteLine($"Numero :{NumeroDeTelefono}");   
            Console.WriteLine($"Mensaje : {Mensaje}");
        }
    }
    public class sms : Notificacion, INotificacion
    {
        public sms(string de, string mensaje, int numeroDeTelefono) : base(de, mensaje)
        {
            NumeroDeTelefono = numeroDeTelefono;
        }
        private int NumeroDeTelefono { get; set; }
        public void notifica()
        {
            Console.WriteLine("Tienes una notificacion nueva de: "+ De);
            NotificacionSMS();
        }
        public void NotificacionSMS()
        {
            Console.WriteLine($"Numero :{NumeroDeTelefono}");
            Console.WriteLine($"Mensaje : {Mensaje}");
        }
    }

    public interface INotificacion
    {
        void notifica();
    }
    

   

}
