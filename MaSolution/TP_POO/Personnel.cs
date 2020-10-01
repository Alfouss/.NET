using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_POO
{
    public class Personnel 
    {
        List<Employe> employeeColl = new List<Employe>();
        private double somme = 0;

        public Personnel()
        {
        }


        public void CalculerSalaire()
        {
            foreach (var item in employeeColl)
            {
                somme += item.CalculerSalaire();
                Console.WriteLine("L'employe " + item.Nom + " a un salaire de " + item.CalculerSalaire());
            }
        }
    
        public void AddEmploye(Employe employeSelect)
        {
          
            employeeColl.Add(employeSelect);

        }

        public double SalaireMoyen()
        {
            Console.WriteLine(somme / employeeColl.Count);
            return somme/employeeColl.Count;
        }


        
    }
}
