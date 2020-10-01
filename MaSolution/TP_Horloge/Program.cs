using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Horloge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recuperer la date actuelle 

            DateTime MavariableDate;
            while (true)
            {
                //recuperer la date

                MavariableDate = DateTime.Now;

                //Affichage de l'heure, minutess et seconde
                Console.WriteLine("--------------------");
                Console.WriteLine("-----" + MavariableDate.ToLongTimeString() + "-------");
                Console.WriteLine("--------------------");
                //Mettre la console en pause 1 seconde;
                System.Threading.Thread.Sleep(1000);
                //Effacer le contenu de la console 
                Console.Clear();
            }


        }
    }
}
