using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Agregation
{
    public class Adresse
    {

        public int Numero { get; set; }
        public string Street { get; set; }

        public override string ToString()
        {
            return "Numero: " + Numero + " " + Street;
        }




    }

}
