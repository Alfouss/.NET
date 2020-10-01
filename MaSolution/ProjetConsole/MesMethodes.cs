using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class MesMethodes
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Affiche()
        {
            Console.WriteLine("Test");
        }

        /// <summary>
        /// Methode qui calcule la siomme de 2 nombre entier
        /// </summary>
        /// <param name="a"> le premier parametre</param>
        /// <param name="b">Le second parametre</param>
        /// <returns> emble d'entier</returns>
        public static int Somme(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tab"></param>
        public static void afficherTableaux(int[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine("L'item: " + item);
            }
        }


        public static void afficherTableaux(double[] tab)
        {
            foreach (var item in tab)
            {
                Console.WriteLine("L'item: " + item);
            }
        }

        public static double sommeEleTab(int[] tab)
        {
            int somme = 0 ;

            foreach (int item in tab)
            {
                somme += item;
            }

            return somme;
        }

        //C'est une surcharge de la precedente methode : en c# contrairement a Java
        //La surcharge concerne le type des parametres et le type de retour en meme temps
        public static double sommeEleTab(double[] tab)
        {
            double somme = 0;

            foreach (int item in tab)
            {
                somme += item;
            }

            return somme;
        }

        //Methode qui trouve le min d'un tableau

        public static int minimum(int[] tab)
        {
            int somme = 0;
            int mini = tab[0];

            foreach (int item in tab)
            {
                if (item < mini )
                {
                    mini = item;
                }
                Console.WriteLine(item);
            }
            Console.WriteLine("Le min est "+mini);
            return somme;
        }

        public static double moyenne(double[] tab)
        {
            int somme = 0;
            double mini = tab[0];

            foreach (int item in tab)
            {
                    somme += item;
            }

            int moyenne = somme / tab.Length;
            Console.WriteLine(moyenne);
            return moyenne;
        }

        //Methode avec parametre optionnels
        //Param optionnels sont definis a la fin de la liste des params et possèdent une valeur par defaut
        public static string identite(string nom, int age = 24, double taille = 1.9)
        {
            
            return "Nom: " + nom + "age" + age + "taille" + taille;
        }

        //Passage de param d'une methode
        //Type valeur, type ref

        public static void Permuter(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;


        }

        public static void invertedString()
        {
            string strI = Console.ReadLine();
            strI = strI.Trim();

            int size = strI.Length;

            //Invert avec tableau
            char[] newString = new char[size];
            Console.WriteLine(newString);


            int count = 0;

            for (int n = size - 1; n >= 0 ; n--)
            {
                newString[count] = strI[n];
                count++;
            }

            Console.WriteLine(newString);

            // Invert avec string 

            Console.ReadKey();
        }

        public static void Composemot()
        {
            string strI = Console.ReadLine();

            strI = strI.Trim();
            strI = strI.Replace("  ", " ");
            string[] arrayString = strI.Split(' ');
            int count = 0;

            for (int i = 0; i < arrayString.Length; i++)
            {
                if (arrayString[i].Length > 1)
                {
                    count++;
                }
            }

            Console.WriteLine("Il y a: " + count + " mot" );
            Console.ReadKey();
        }

        public static void palindrome()
        {
            string strPal = Console.ReadLine();
            strPal = strPal.Trim();
            strPal = strPal.Replace("  ", " ");
            string[] arrayString = strPal.Split(' ');
            string wordInvert = null;

            for (int i = 0; i < arrayString.Length; i++)
            {

                for (int j = arrayString[i].Length - 1; j >= 0; j--)
                {
                    wordInvert += arrayString[i][j];

                }

                if ( wordInvert == arrayString[i])
                {
                    Console.WriteLine("Is palindrome");

                }

            }

            Console.ReadKey();
        }
    }
}
