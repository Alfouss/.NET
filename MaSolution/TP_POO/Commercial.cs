using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public abstract class Commercial : Employe
    {
        public double ChiffreAffaire { get; set; }
        public static double POURCENTAGE = 0.2;


        protected Commercial(string nom, string prenom, int age, string entree, double chiffreAffaire) : base(nom, prenom, age, entree)
        {
            ChiffreAffaire = chiffreAffaire;
        }

        
    }
}
