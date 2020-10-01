using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Encapsulation
{
    public class Animal
    {
        public string Nom { get; set; }
        public int Age { get; set; }

        public Animal(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }

        public Animal()
        {

        }

        public Animal(string nom)
        {

        }

        //CLass fille redefinir en vituelle
        public virtual void Identite()
        {
            Console.WriteLine("Je suis un Animal");        
        }

        public override string ToString()
        {
            return "Nom: " + Nom + "Age: " + Age;
        }

    }
}
