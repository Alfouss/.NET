using MyStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_Gestion_De_Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix, num, quantite, indice;
            double prix;
            string nom;

            List<Article> stock = new List<Article>();

            do
            {
                Console.WriteLine("-------------------MENU------------------");
                Console.WriteLine("1-Rechercher un Article par son numero");
                Console.WriteLine("2-Ajouter un article");
                Console.WriteLine("3-Supprimez un article par le numero");
                Console.WriteLine("4-rechercher par son nom");
                Console.WriteLine("5-Afficher tous les articles");
                Console.WriteLine("6-Trouver grâce a l'intervalle de prix");
                Console.WriteLine("7-Quitter");
                Console.WriteLine("Donner votre choix: ");


                choix = int.Parse(Console.ReadLine());

                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Donnez le numero de l'article a rechercher: ");
                        num = int.Parse(Console.ReadLine());
                        indice = Rechercher(stock, num);
                        if (indice == -1)
                        {
                            Console.WriteLine("Article introuvable");
                        }
                        else
                        {
                            Console.WriteLine(stock[indice]);
                        }
                        break;


                    case 2:
                        Console.WriteLine("Donnez le numero d'un article ajouter");
                        num = int.Parse(Console.ReadLine());;
                        indice = Rechercher(stock, num);

                        if (indice != -1)
                        {
                            Console.WriteLine("Existe deja");

                        }
                        else
                        {
                            Console.WriteLine("Donnez le nom: ");
                            nom = Console.ReadLine();
                            Console.WriteLine("Donnez le prix: ");
                            prix = int.Parse(Console.ReadLine());
                            Console.WriteLine("Donnez la quantite: ");
                            quantite = int.Parse(Console.ReadLine());
                            

                            stock.Add(new Article(num, quantite, nom, prix));
                            Console.WriteLine("Article ajouter ");
                        }

                        break;
                    case 3:
                        Console.WriteLine("Donnez le numero d'un article pour le supprimez");
                        num = int.Parse(Console.ReadLine());;
                        indice = Rechercher(stock, num);

                        if (indice == 1)
                        {
                            Console.WriteLine("n'existe deja");

                        }
                        else
                        {
                            nom = stock[indice].nom;
                            prix = stock[indice].prix;
                            quantite = stock[indice].quantite;

                            stock.Remove(new Article(num, quantite, nom, prix));
                             
                            Console.WriteLine("Article supprimer ");
                        }

                        break;
                        case 4:
                            Console.WriteLine("Donnez le numero du nom de l'article");

                        nom = Console.ReadLine(); 

                        int count = 0;

                        for (int i = 0; i < stock.Count; i++)
                        {
                            if (stock[i].nom == nom.ToLower())
                            {
                                Console.WriteLine("Le nom: " + stock[i].nom + " existe bien");
                                count++;
                            }
                        }

                        Console.WriteLine("Le nom est: " + stock[count].nom);


                        break;
                        case 5:
                            Console.WriteLine("Affichage de tout les articles");


                            foreach (var item in stock)
                            {
                                Console.WriteLine("Nom " + item.nom + " prix: " + item.nom + " quantite :" + item.quantite + " numero: " + item.numero);
                            }

                        break;
                        case 6:
                            Console.WriteLine("Donnez deux prix pour cree une intervale de prix");

                            Console.WriteLine("min");
                            int min = int.Parse(Console.ReadLine()); ;

                            Console.WriteLine("max");
                            int max = int.Parse(Console.ReadLine());

                        if(min < 0 || max < 0 || min> max)
                        {
                            Console.WriteLine("N'existe pas ou alors vous vous ête tromper dans l'ordre des num ");
                            break;
                        }

                        for (int i = 0; i < stock.Count; i++)
                        {
                            if (stock[i].prix >= min && stock[i].prix <= max)
                            {
                                Console.WriteLine("Nom " + stock[i].nom + " prix: " + stock[i].nom + " quantite :" + stock[i].quantite + " numero: " + stock[i].numero);
                            }
                        }

                        
                        break;
                        case 7:
                            Console.WriteLine("Fin de programme");
                            break;
                        default:
                            Console.WriteLine("Choix Invalide");
                            break;
                    }


            } while (choix != 6);

            Console.ReadKey();
        }

        //Qui verifie l'existance d'un article grace a un numero
        static int Rechercher(List<Article> l, int num)
        {
            int indice = -1;

            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].numero == num)
                {
                    indice = i;
                    break;
                }
            }

            return indice;
        }


    }
}
