using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = 10;
            double n2 =3;
            int n3= 17;
            int  n4 = 3;
            Calculadora Calc = new Calculadora("Casio", "fx-899");
            double total = Calc.Sumar (n1,n2); 
            Console.WriteLine( "la suma es: "+total);
          
            // resta
            double diferencia = Calc.Restar(n1, n2);
            Console.WriteLine("la diferencia es: "+diferencia);
            
            //multiplicacion
            double multiplicar = Calc.Multiplicacion(n1, n2);
            Console.WriteLine("la multiplicacion es: "+ multiplicar);

            double division = Calc.Division(n1, n2);
            Console.WriteLine("la dicision es: "+division);

            CalculadoraCientifica cientifica = new CalculadoraCientifica("saso", "Gb-167");
            double pontencia = cientifica.Potencias(n1, n2);
            Console.WriteLine("la potencia es:"+pontencia);

            double Raiz = cientifica.RaizCuadrada(n1);
            Console.WriteLine("la raiz de:"+n1 +" es:" +Raiz);

            int modulo = cientifica.Modulo(n3,n4);
            Console.WriteLine("el modulo  es:" + modulo);

            double logari = cientifica.Logaritmo(n1, n2);
            Console.WriteLine("el logaritmo es:"+ logari);

            MostrarTipo(Calc);
            MostrarTipo(cientifica);


            Console.ReadLine();
        }
        public static void MostrarTipo(Calculadora calculadora)
        {
            Console.WriteLine(calculadora.Tipo());
        }
    }
}
