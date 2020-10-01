using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class Vendeur : Commercial
    {

        public static double POURCENTAGE = 0.2;
        public double BONUS_VENDEUR = 400;
        

        public Vendeur(string nom, string prenom, int age, string entree, double chiffreAffaire): base(nom, prenom, age, entree, chiffreAffaire)
        {
            ChiffreAffaire = chiffreAffaire;
        }
        
        
        public override double CalculerSalaire()
        {
            
            return ChiffreAffaire * POURCENTAGE + BONUS_VENDEUR ; 

        }

        public override string getTitre()
        {
            return "Le vendeur";
        }

    }
}
