using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class ManutARisque: Manutentionnaire
    {
        private static int PRIME = 200;

        public ManutARisque(string nom, string prenom, int age, string entree, double heures) : base(nom, prenom, age, entree, heures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIME;
        }
    }
}
