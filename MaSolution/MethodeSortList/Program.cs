using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodeSortList
{
    class Program
    {
        static int CompareByLength(string x, string y)
        {
            if (x == null )
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int interval = x.Length.CompareTo(y.Length);
                    if (interval != 0)
                    {
                        return interval;
                    }
                    else
                    {
                        return x.CompareTo(y);// return un nombre si c'est vrai

                    }

                }
            }
        }
        static void Main(string[] args)
        {

            List<string> maList = new List<string>();

            maList.Add("fol");
            maList.Add("xsxs");
            maList.Add("hghghv");
            maList.Add("polcsck");

            maList.Sort();

            foreach (var item in maList)
            {
                Console.WriteLine(item);
            }


            maList.Sort(CompareByLength);

            foreach (var item in maList)
            {
                Console.WriteLine(item );
            }


            Console.WriteLine();

            Console.ReadKey();
        }  
    }
}
