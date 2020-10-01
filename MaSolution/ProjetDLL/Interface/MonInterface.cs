using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace ProjetDLL.Interface
{
     public interface MonInterface
    {
        //MonInterface est une pseudo classe abstraite
        //Et ne contien que des signatures de methode
        int Calcule();
        int calcul();
        double Division();

        List<Produitss> GetAll();
        Produitss GetOne();
        void Delete(Produitss p);
        void Update(Produitss p);
        Produitss FindById(int id);
    }
    public class Produitss
    {

    }
}
