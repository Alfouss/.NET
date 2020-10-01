using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Abstraction
{
    public class Homme: Personne
    {

        public override void SePresenter()
        {
            Console.WriteLine("Je suis un homme et je m'appel " + Nom + " " + Prenom);
        }

    }
}
