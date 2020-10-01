using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class Producteur:Employe
    {

        private static double FACTEUR_UNITE = 5.0;
        public double unite { get; set; }


        public Producteur(string nom, string prenom, int age, string entree, double unite) : base(nom, prenom, age, entree)
        {
            Console.WriteLine("Nom: " + Nom);
        }


        public override double CalculerSalaire()
        {

            return unite * FACTEUR_UNITE;

        }

        public override string getTitre()
        {
            return "Le technicien";
        }

        
    }
}
