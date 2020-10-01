using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetConsole
{
    class Produit: Object
    {
        #region Propriete
        //Attribut(L'etat d'un objet)

        public int id;
        public string description;
        public double prix;

        //Propriete global
        public static string LieuConstruction = "France";

        #endregion


        #region Constructeurs
        // Constructeurs methode public qui porte le nom de la class et permet d'initialiser les propriete

        public Produit(int id, string description, double prix)
        {
            this.id = id;
            this.description = description;
            this.prix = prix;
        }

        public Produit(string description)
        {
            this.description = description;
        }

        public Produit()
        {
            Console.WriteLine("Sans parametre");
        }

        #endregion

        #region Methodes

        public double TvaProduit(Produit p)
        {
            return p.prix * 0.2;
        }

        public double prixTTC(Produit p)
        {
            return p.prix * 1.2;
        }

        #endregion     

        public override string ToString()
        {
            return "ID " + id + " Description " + description + " prix " + prix;
        }

        
    }
}
