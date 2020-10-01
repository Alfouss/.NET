using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class TechARisque : Producteur
    {
        private static int PRIME = 200;

        public TechARisque(string nom, string prenom, int age, string entree, double unite) : base(nom, prenom, age, entree, unite)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }


    }
}
