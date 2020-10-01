using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public abstract class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string Date { get; set; }

        public Employe()
        {

        }

        public Employe(string nom, string prenom, int age, string entree) {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            Date = entree;

        }


        public virtual string getTitre()
        {
            return "L'employé";
        }
        public abstract double CalculerSalaire();


        public string getNom() {
            return this.getTitre() + " "  + Nom + " " + Prenom;
        }




    }
}
