using ProjetDLL.Encapsulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Heritage
{
    public class Chien : Animal
    {

        public override void Identite()
        {
            Console.WriteLine("Je suis un chien");
        }
    }
}

