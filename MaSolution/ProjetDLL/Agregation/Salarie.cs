using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Agregation
{
    public class Salarie
    {
        public string Nom { get; set; }
        public int Salaire { get; set; }

        //Agrégation - Association - composition: le fait qu'un objet puisse faire partie
        //des attribut d'un autre objet
        public Adresse Adr { get; set; }

        public override string ToString()
        {
            return "Nom: " + Nom + " " + Salaire; 
        }

    }
}
