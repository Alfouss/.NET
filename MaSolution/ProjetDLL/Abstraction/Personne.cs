using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Abstraction
{
    public abstract class Personne
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne()
        {

        }

        public Personne(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public abstract void SePresenter();

        
        public virtual void Afficher()
        {
            Console.WriteLine(" Je m'appel Nom: " + Nom + "prenom: " + Prenom); 

        }

        public override string ToString()
        {
            return "Nom: " + Nom + "prenom: " + Prenom;
        }
    }
}
