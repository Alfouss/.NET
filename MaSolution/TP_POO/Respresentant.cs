using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class Respresentant: Commercial
    {
        public static double POURCENTAGE = 0.2;
        public double BONUS_VENDEUR = 800;
        public Respresentant(string nom, string prenom, int age, string entree, double chiffreAffaire) : base(nom, prenom, age, entree, chiffreAffaire)
        {
            this.ChiffreAffaire = chiffreAffaire;
        }


        public override double CalculerSalaire()
        {
            return POURCENTAGE * ChiffreAffaire + BONUS_VENDEUR;

        }

        public override string getTitre()
        {
            return "Le representant";
        }
    }
}
