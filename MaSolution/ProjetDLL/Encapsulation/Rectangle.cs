using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Encapsulation
{
    public class Rectangle
    {
        //Chaps
        private double hauteur = 15;
        private double longueur = 20;


        //Accesseur(Propriete) - getter - setter
        public double Hauteur{

            get
            {
                return hauteur;
            }
            set
            {
                if (value > 0)
                {
                    hauteur = value;
                }
                else { Console.WriteLine("hauteur ne peut etre negative"); }
            }
        }

        public double Longeur
        {

            get
            {
                return longueur;
            }
            set
            {
                if(value > 0)
                {
                    longueur = value;
                }
                else { Console.WriteLine("Longueur ne peut etre negative"); }
                
            }
        }

        public double Surface()
        {
            return hauteur * longueur;
        }
    }
}
