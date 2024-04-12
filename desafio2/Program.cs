using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            string Correo = "pruebamary358@gmail.com ";
            string Asunto = "Importancia ";
            string De = "Maria";
            string Mensaje = "Necesito estudiar.  ";
            int NumeroDeTelefono = 12453267;

            Email email = new Email(Correo, De, Asunto, Mensaje);
            Console.WriteLine("Informacion de Email"); 
            email.notifica();
            Console.WriteLine("");

            whats Whats = new whats(De,Mensaje,NumeroDeTelefono);
            Console.WriteLine("Notificacion de whatsap");
            Whats.notifica();
            Console.WriteLine("");

            sms Sms = new sms(De, Mensaje, NumeroDeTelefono);
            Console.WriteLine("Notificacion de SMS");
            Sms.notifica();
            Console.WriteLine("");


            Console.ReadLine();
        }

    }

   
}
