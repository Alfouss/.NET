using ProjetDLL.Encapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Heritage
{
    public class Chat:Animal
    {
        public static int compteur = 0;
        public Chat(string nom, int age): base(nom, age)
        {
            //base permet d'appeler le constructeur de la classe mere
            
        }

        public Chat()
        {
            compteur++;
        }

        public Chat(string nom) : base(nom)
        {
            Nom = nom;
        }

        public override void Identite()
        {
            Console.WriteLine("Je suis un chat");

        }
    }
}
