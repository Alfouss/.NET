using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStruct
{
    public struct Article
    {
        public int numero; 
        public int quantite;
        public string nom;
        public double prix;

        public Article(int numero, int quantite, string nom, double prix)
        {
            this.numero = numero;
            this.quantite = quantite;
            this.nom = nom;
            this.prix = prix;
        }

        public override string ToString()
        {
            return "Numero:" + numero+ "quantite: " + quantite+  "nom: " + nom + "prix: " + prix;
        }
    }
}
