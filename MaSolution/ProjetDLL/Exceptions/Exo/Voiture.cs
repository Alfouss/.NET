using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Exceptions.Exo
{
    public class Voiture
    {

        public string Marque { get; set; }
        public int Vitesse { get; set; }

        public Voiture() 
        {
           
        }

        public Voiture(string marque, int vitesse)
        {
            this.Marque = marque;
            this.Vitesse = vitesse;
        }

        public override string ToString()
        {
           return  "Marque: " + Marque + " " +"vitesse: " + Vitesse;
        }
    }
}
