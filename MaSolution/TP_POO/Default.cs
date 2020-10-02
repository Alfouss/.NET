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
            coll.AddEmploye(new Representant("Tom", "Call", 20, "10/05/1444", 8500));
            coll.AddEmploye(new Producteur("Draymon", "Green", 20, "10/05/1444", 2));
            coll.AddEmploye(new Manutentionnaire("Dwayne", "Johnson", 20, "10/05/1444", 1));
            coll.AddEmploye(new TechARisque("RajonLebron", "Rondo", 20, "10/05/1444", 2));
            coll.AddEmploye(new ManutARisque("Dwayne", "Johnson", 20, "10/05/1444", 1));



            coll.CalculerSalaire();
            coll.SalaireMoyen();

            Console.ReadKey();
        }


    }
}
