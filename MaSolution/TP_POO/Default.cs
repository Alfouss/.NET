using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    class Default
    {

        static void Main(string[] args)
        {
            Employe vendeur = new Vendeur("Jean", "Marc", 20, "10/05/1444", 4000);
            vendeur.CalculerSalaire();

            Console.WriteLine(vendeur.getNom());

            Personnel coll = new Personnel();
            coll.AddEmploye(new Vendeur("Jean", "Marc", 20, "10/05/1444", 4000));
            coll.AddEmploye(new Vendeur("Tom", "Call", 20, "10/05/1444", 8500));
            coll.AddEmploye(new Vendeur("Dwayne", "Johnson", 20, "10/05/1444", 4090));
            coll.AddEmploye(new Vendeur("Lebron", "James", 20, "10/05/1444", 2690));


            coll.CalculerSalaire();
            coll.SalaireMoyen();

            Console.ReadKey();
        }


    }
}
