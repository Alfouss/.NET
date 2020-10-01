using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Abstraction
{
    public class Femme: Personne
    {
        public override void SePresenter()
        {
            Console.WriteLine("Je suis une femme et je m'appel " + Nom + " " + Prenom);
        }
    }
}
