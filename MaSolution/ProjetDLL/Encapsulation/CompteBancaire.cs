using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Encapsulation
{  
    [Serializable]
    public class CompteBancaire
    {

        #region Propriétés

            public double Solde {get;set;} 
            public int Numero {get; set;}
            public static int compteur { get; set; }
        #endregion

        #region Constructeur
        public CompteBancaire()
        {
            compteur++;
        }
        public CompteBancaire(int numero):this()
        {
            
        }
        public CompteBancaire(int numero, double solde): this()
            {
                Numero = numero;
                Solde = solde;
            }
        #endregion

        #region Methodes
            public void Depot(double montant)
            {
                Solde += montant;
            }
            public  void Retrait(double montant)
            {
                if (montant < Solde) {
                    Console.WriteLine("Retrait autorisé");
                }
                else {

                throw new SoldeException("Vous n'avez aps assez de fond");
            }
        }

        #endregion

        public override string ToString()
        {
            return "Compte numero: " + Numero + " Solde " + Solde;
        }



        //Comparaison de 2 objet du type compteBancaire
        public override bool Equals(object obj)
        {
            return obj is CompteBancaire bancaire &&
                   Solde == bancaire.Solde &&
                   Numero == bancaire.Numero;
        }

        public bool Egale(object obj)
        {
            CompteBancaire b = (CompteBancaire)obj; 
                return Solde == b.Solde &&
                   Numero == b.Numero;
        }
    }
}


