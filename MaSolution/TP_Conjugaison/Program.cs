using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Conjugaison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objectif: extraction de sous chaines, concatenation et comparaison

            string[] sujet = { "Je", "Tu", "Il", "Nous", "Vous", "Ils" };
            string[] terminaison = { "e", "es", "e", "ons", "ez", "ent" };

            string verbe = null;
            int size = 0;

            while (true)
            {
                Console.WriteLine("Donnez un verbe du premie groupe: ");
                verbe = Console.ReadLine();


                //Verifier si le verbe se termine par er
                size = verbe.Length;

                string endString = verbe.Substring(size - 2);
                if (endString == "er")
                {
                    Console.WriteLine("Ok");
                    break;
                }
                else
                {
                    Console.WriteLine("Il ne se termine pas par er -- Veuillez Reesayez");
                }

            }

            string radical = verbe.Substring(0, size - 2);
            for (int i = 0; i < sujet.Length; i++)
            {
                Console.WriteLine(sujet[i] + " " + radical + terminaison[i]);
            }
            Console.ReadKey();


        }
    }
}
