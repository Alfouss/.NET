using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetDLL.Interface
{
    public class ProduitImpl : MonInterface, MonInterface2
    {
        public int somme()
        {
            throw new NotImplementedException();
        }

        public double somme2()
        {
            throw new NotImplementedException();
        }

        int MonInterface.calcul()
        {
            throw new NotImplementedException();
        }

        int MonInterface.Calcule()
        {
            throw new NotImplementedException();
        }

        void MonInterface.Delete(Produitss p)
        {
            throw new NotImplementedException();
        }

        double MonInterface.Division()
        {
            throw new NotImplementedException();
        }

        Produitss MonInterface.FindById(int id)
        {
            throw new NotImplementedException();
        }

        List<Produitss> MonInterface.GetAll()
        {
            throw new NotImplementedException();
        }

        Produitss MonInterface.GetOne()
        {
            throw new NotImplementedException();
        }

        void MonInterface.Update(Produitss p)
        {
            throw new NotImplementedException();
        }
    }

}
