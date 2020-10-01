using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_Voyelle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Verifier les voyelle 

            char[] voyellesArray = {'a', 'e', 'i', 'o', 'u', 'y'};
            int[] nVoyelles = new int[voyellesArray.Length];

            Console.WriteLine("Trouvez les voyelle du mot");

            for (int d = 0; d < voyellesArray.Length; d++)
            {
                nVoyelles[d] = 0;
            }

            Console.WriteLine("Donnez votre mot: ");
            string mot = Console.ReadLine();

            mot = mot.ToLower();

            for (int g = 0; g < mot.Length; g++)
            {
                for (int z = 0; z < nVoyelles.Length; z++)
                {
                    if (mot[g] == voyellesArray[z])
                    {
                        nVoyelles[z]++;
                    }
                }
            }

            for (int r = 0; r < voyellesArray.Length; r++)
            {
                Console.WriteLine("Il y a " + nVoyelles[r] + " fois la voyelle: " + voyellesArray[r]);
            }





            Console.ReadKey();

        }
    }
}
