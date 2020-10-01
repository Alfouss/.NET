using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class Manutentionnaire:Employe
    {
        public static double SALAIRE_HORAIRE = 65;
        public double heures { get; set; }


        public Manutentionnaire(string nom, string prenom, int age, string entree, double heures) : base( nom,  prenom, age, entree)
        {
            this.heures = heures;
        }

        public override double CalculerSalaire()
        {
            return heures * SALAIRE_HORAIRE;
        }

        public override string getTitre()
        {
            return "Le manutentionnaire";
        }
      
    }
}
