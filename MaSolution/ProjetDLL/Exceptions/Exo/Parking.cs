
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Exceptions.Exo
{
    public class Parking
    {
        //Attribut de type primitif possede des valeur par defut in, double... leur valeur par defaut est 0
        //Les boolean : false
        public Voiture[] tabVoiture { get; set; }
        public int cpt { get; set; }
        public Parking()
        {
            tabVoiture = new Voiture[5];
        }

        public void garerVoiture(Voiture v)
        {
            if (cpt < 5)
            {
                tabVoiture[cpt] = v;
                cpt++;
            }
            else
            {
                throw new ParkingException("Pas de place dans le parking");
            }
        }
    }
}
