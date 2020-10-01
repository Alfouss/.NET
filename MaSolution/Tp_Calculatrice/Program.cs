using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Calculatrice
{
    class Program
    {
        static void Main(string[] args)
        {

            string choix = "";
            double num1 = 0;
            double num2 = 0;
            double Entrer= 0;
            Console.WriteLine("Calculatrice");
            Console.WriteLine("addition a");
            Console.WriteLine("soustraction s");
            Console.WriteLine("multiplication m");
            Console.WriteLine("Division d");

            do
            {
                Console.WriteLine("Faite votre choix");
                choix = Console.ReadLine();

            } while (!(choix == "a" || choix == "s" || choix == "m" || choix == "d"));

            do
            {
                Console.WriteLine("Merci de saisir un nombre");
                try
                {

                    Entrer = Convert.ToDouble(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {

                    throw;
                }
            } while(true);


            num1 = Entrer;

            do
            {
                Console.WriteLine("Merci de saisir un nombre");

                try
                {

                    Entrer = Convert.ToDouble(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {

                    throw;
                }
            } while (true);

            num2 = Entrer;

            switch (choix)
            {
                case "a":
                    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
                    break;
                case "s":
                    Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
                    break;
                case "m":
                    Console.WriteLine("{0} * {1} = {2}", num1, num2, num1 * num2);
                    break;
                case "d":
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
                    int v1 = (int)num1;
                    int v2 = (int)num2;
                    Console.WriteLine(" Modulo (reste de la division) {0} % {1} = {2}", num1, num2, num1 % num2);

                    break;
                default:
                    break;
            }


            Console.ReadKey();


        }
    }
}
