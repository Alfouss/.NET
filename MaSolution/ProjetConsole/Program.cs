using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProjetDLL;
using ProjetDLL.Abstraction;
using ProjetDLL.Agregation;
using ProjetDLL.Encapsulation;
using ProjetDLL.Heritage;
using ProjetDLL.Interface;

namespace ProjetConsole
{
    class Program 
    {
        enum Jours
        {
            LUNDI = 1,
            MARDI = 2, 
            MERCREDI = 3, 
            JEUDI = 4, 
            VENDREDI = 5
        }

        struct Fournisseur
        {
           public int id;
           public string nom;

            public override string ToString()
            {
                return "Nom du fournisseur: " + nom;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Formation C#");
            MesMethodes.Affiche();
            Test.Main();

            #region Variables
            //Variable Zone memoire typé
            //Type primitif: entier, charactere, réels, boolean
            //Type complexe string, classe, structures, enumerations
            //Entier: byte(1octet), short(2), int(4), long(8)
            //Reels: float 4 ,double 8, decimal 16

            //Declaration exemple type nom;
            int myInt = 10; // Initilisation
            char mychar = 'C';
            bool mybool = false;
            double myDouble = 15.5;
            string myString = "ma chaine de caractere";

            //Inference du type le compilateur affiche le type de la variable
            var x = 10;

            //Formatage de chaine de caractere:
            Console.WriteLine("Ma variable X {0}, Ma variable X {1}", x, myDouble);
            Console.WriteLine(String.Format("myInt = {0}", myInt));
            Console.WriteLine("\tDawan \nBonjour");
            Console.WriteLine(@"Je suis chez Dawan,
                                 Je commence");
            Console.WriteLine("Le contenu de la variable de type string" + myString);


            #endregion

            #region Operateur 
            //Operateur arithmetique: +, -, *...
            //Incrementation, decrementation
            //operateur combine +=, -= ...
            //operarteur de comparaison <=, >=, !=....
            //Operateur logique: &&, || ^ (exclusif), !
            //Post/ pre incrementation int i = 5; ++i; 
            #endregion

            #region Constante
            //Constante variable inchangeable

            #endregion

            #region Conversion de type
            //Transtypage implicite

            short myShort = 10;
            int i2 = myShort;
            double d = i2;

            //Transtypage explicite
            int i3 = 15;
            short sr = (short)i3;// Cast: conversion explicte 

            //On peut aussi utliser des methode de conversion
            short sr2 = Convert.ToInt16(i3);

            //Conversion de type incompatible
            string str = "45";
            int i5 = Convert.ToInt32(str); //Le cqst impossible entretype non compatible
            int i6 = int.Parse(str);// methode parse fournit par le type en question

            Console.Write("Merci de fournir votre age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Votre age est: " + age);
            #endregion

            #region Condition

            int xT = 10;
            switch (xT)
            {
                case 10:
                    Console.WriteLine("Est superieur");
                    break;
                case 11:
                    Console.WriteLine("Est superieur");
                    break;
                case 12:
                    Console.WriteLine("Est superieur");
                    break;
                default:
                    Console.WriteLine("Est inferieur");

                    break;

            }
            //if else
            //Ternaire

            #endregion

            #region Boucle
            //Boucle: ensemble d'instruction repetitive for, foreach
            //boucle condidtionelle: while, do-while



            int[] tab = { 1, 2, 3 };
            foreach (var element in tab)
            {
                Console.WriteLine(element);
            }

            int s = 5;
            while (s < 10)
            {
                Console.WriteLine("Passage n° :" + s);
                s++;
            }

            do
            {
                Console.WriteLine("Passage n° :" + s);
                s++;
            } while (s < 15);


            #endregion

            #region Tableaux

            int[] tableaux = new int[3];
            tableaux[0] = 1;
            tableaux[1] = 6;
            tableaux[2] = 10;

            int size = tableaux.Length;
            Console.WriteLine("La taille est: " + size);

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(tableaux[i]);
            }

            foreach (int item in tableaux)
            {
                Console.WriteLine(item);
            }

            int[] tableaux2 = { 4, 3, 5 };

            int[,] matrice = new int[2, 3];
            matrice[0, 0] = 1;
            matrice[0, 1] = 15;
            matrice[0, 2] = 25;
            matrice[1, 0] = 35;
            matrice[1, 1] = 45;
            matrice[1, 2] = 55;

            int[,] matrice2 = { { 1, 2, 3 }, { 8, 5, 9 } };

            int nbLigne = matrice2.GetLength(0);
            int nbColonne = matrice2.GetLength(1);

            Console.WriteLine("NB ligne de la matrice2 " + nbLigne);
            Console.WriteLine("NB colonne de la matrice2 " + nbColonne);

            for (int i10 = 0; i10 < nbLigne; i10++)
            {
                for (int j = 0; j < nbColonne; j++)
                {
                    Console.WriteLine("NB ligne {0}" + "NB colonne {1}", i10, j);
                    Console.WriteLine(matrice2[i10, j]);
                }
            }

            #endregion

            #region Methode

            //Methode: ensemble reutilisable.
            //Procedure: Une methode qui ne renvoie aucune valeur
            //Fonction: Methode qui renvoie une valeur
            //Methode qui calcule la somme des elements d'un tableau

            int somme = MesMethodes.Somme(5, 1);
            Console.WriteLine("La somme de 2 nombre est: " + somme);
            MesMethodes.afficherTableaux(tableaux2);
            MesMethodes.minimum(tableaux2);
/*            MesMethodes.moyenne(tableaux2);
*/
            int p = 5;
            int m = 10;
            MesMethodes.Permuter(ref p, ref m);
            Console.WriteLine("m vaut nmaintenant " + m + "p vaut nmaintenant" + p);
            #endregion

            #region Enumeration

            Jours jours = Jours.MARDI;

            Console.WriteLine(jours);
            Console.WriteLine("Merci de saisir le code du jour entre 1 et 5: ");
            int codeJours = Convert.ToInt32(Console.ReadLine());
            Jours joursChoisie = (Jours)codeJours;
            Console.WriteLine("Jours choisie = {0} ", joursChoisie);



            #endregion

            #region Date
            Console.WriteLine("Manipulation des dates");
            DateTime dt = new DateTime();
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);

            DateTime dt2 = new DateTime(2019, 3, 1, 17, 52, 52);
            Console.WriteLine(dt2);

            string dtString = "5/1/2029 8:30:52 AM";
            string dtString2 = "5/1/2020 8:30:52 AM";

            DateTime dt3 = DateTime.Parse(dtString);
            Console.WriteLine(dt1);

            //Comparaison
            Console.WriteLine("Comparaison dt1 et dt2 " + dt1.CompareTo(dt2));

            //Opereation
            Console.WriteLine("Operation dt1 " + dt1);
            Console.WriteLine("Operation " + dt1.AddDays(2));

            //Recherche
            Console.WriteLine("Date dt1 " + dt1.Date);
            Console.WriteLine("Jour du mois " + dt1.Day);

            //Format court de la date  
            Console.WriteLine(dt1.ToShortDateString());

            //Format long de la date  
            Console.WriteLine(dt1.ToLongDateString());

            //Format court de l'heure 
            Console.WriteLine(dt1.ToShortTimeString());

            //Format long de la date  
            Console.WriteLine(dt1.ToLongDateString());



            #endregion

            #region Classe String

            string strr = "ma chaine de caratere";
            Console.WriteLine("Taille de la chaine nb de char: " + str.Length);

            strr = strr.Trim();
            Console.WriteLine("Taille de la chaine nb de char sans espaces: " + str.Length);

            char premierChar = strr[0];
            Console.WriteLine("Taille de la chaine nb de char: " + premierChar);

            for (int i7 = 0; i7 < strr.Length; i7++)
            {
                Console.WriteLine(strr[i7]);
            }

            string ssChaine = strr.Substring(2, 5);
            Console.WriteLine("Ma sous chaine apres extraction");

            string ssChaine2 = strr.Substring(2, 5);
            Console.WriteLine("Ma sous chaine apres extraction: " + ssChaine2);

            string ssChaine3 = strr.Substring(3);
            Console.WriteLine("Ma sous chaine apres extraction: " + ssChaine3);

            //Split

            string ch = "John;Marc;Thomas";
            string[] tabCh = ch.Split(';');

            //Join 
            var names = new String[] { "John", "Marc", "Thomas" };
            var stringNames = string.Join(";", names);

            //Remplacer un char dans une chaine 

            strr.Replace("m", "t");
            Console.WriteLine("Remplacement du M par T: " + strr);

            //Concatenation de chaine de caractere

            string chaine2 = "test";
            chaine2 = chaine2 + "concatenation";
            string chaine3 = "une autre concatenation";

            string chaine4 = string.Concat(chaine2, chaine3);
            Console.WriteLine("chaine concatenee: " + chaine4);
            #endregion

            /*MesMethodes.invertedString();*/
            /*MesMethodes.Composemot();*/
            /*MesMethodes.palindrome();/*/

            //MVerification du contenu

            string str10 = "test";
            string str11 = "t";
            string str12 = str11 + "est";

            //Comparaison de contenu

            Console.WriteLine(Object.ReferenceEquals(str10, str12));

            //Comparaison 

            Console.WriteLine(Object.ReferenceEquals(str10, str12));
            
            string str13 = str10;
            Console.WriteLine(Object.ReferenceEquals(str10, str13));

            //Autres methodes de la class string 
            Console.WriteLine(str10.StartsWith("t"));
            Console.WriteLine(str10.EndsWith("t"));
            Console.WriteLine(str10.IndexOf("t"));

            // StringBuilder 

            StringBuilder builder = new StringBuilder();
            builder.Append('-',10).AppendLine().Append("Mon builder").AppendLine().Append('-', 10);
            Console.WriteLine(builder.ToString());




            #region Les classe

            //attribut
            //constructeur

            Produit p1 = new Produit();
            p1.id = 1;
            p1.description = "PC dell";
            p1.prix = 1200;

            double ttc = p1.prixTTC(p1);
            Produit p2 = new Produit(2, "HP", 1000);

            #endregion

            #region Les structures

            Fournisseur fournisseur1 = new Fournisseur();
            fournisseur1.id = 1;
            fournisseur1.nom = "Carrefour";

            Fournisseur fournisseur2 = fournisseur1;
            Produit p3 = p1;

            fournisseur1.nom = "Auchan";
            Console.WriteLine(fournisseur2);

            #endregion

            #region MyRegion
            //Collection: structures de stockage dynamiques
            //Collection fortement typées - collection faiblement typée

            //Liste collection fortement typée
            List<string> maListe = new List<string>();
            maListe.Add("test1");
            maListe.Add("test2");
            maListe.Add("test3");

            //taille de la liste

            Console.WriteLine("Taille de la liste "+ maListe.Count);

            //parcours de la liste
            for (int i = 0; i < maListe.Count; i++)
            {
                Console.WriteLine(maListe[i]);
            }

            foreach (var item in maListe)
            {
                Console.WriteLine(item);
            }


            //Dictionnaire
            //Collection typé
            //Utilisation du dictionnaire que lorsqu'on a un ficher .properties

            Console.WriteLine("Les collections de type dictionnaire");
            Dictionary<int, string> dictionnaire = new Dictionary<int, string>();
            Console.WriteLine("Le nombre d'element dans le dictionnaire " + dictionnaire.Count);
            //dictionnaire.Add(1, "Admin");
            //dictionnaire.Add(2, "password");
            Console.WriteLine("Le nombre d'element dans le dictionnaire " + dictionnaire.Count);


            for (int i4 = 0; i4 < 13; i4++)
            {
                dictionnaire.Add(i4, "chaine " + i4);
            }
            Console.WriteLine("Le nombre d'element dans le dictionnaire " + dictionnaire.Count);

            foreach (var cle in dictionnaire.Keys)
            {
                Console.WriteLine("Clé: " + cle + "Valeur: " +dictionnaire[cle]);
            }

            dictionnaire.Remove(1);
            Console.WriteLine("Le nombre d'element dans le dictionnaire " + dictionnaire.Count);

            if (dictionnaire.ContainsKey(1))
            {
                Console.WriteLine(dictionnaire[1]);
            }
            else
            {
                Console.WriteLine("N'existe pas");
            }

            dictionnaire.Clear();
            Console.WriteLine("Le nombre d'element dans le dictionnaire " + dictionnaire.Count);

            //ArrayList
            //Collection faiblement typé 


            ArrayList monArray = new ArrayList();
            monArray.Add(10);
            monArray.Add(true);
            monArray.Add("test");
            Console.WriteLine("Taille de monArray: " + monArray.Count);

            monArray.Remove(10);
            int positionTrue = monArray.IndexOf(true);
            monArray.Insert(positionTrue, 50);

            int positionTrue2 = monArray.IndexOf(true);

            Console.WriteLine(positionTrue == positionTrue2);


            for (int i8 = 0; i8 < monArray.Count; i8++)
            {
                Console.WriteLine(monArray[i8]);
            }

            foreach (var item in monArray)
            {
                Console.WriteLine(item);
            }

            monArray.Clear();


            #endregion


            #region Concepts de la programmation objets

            //Encapsulation - heritage - abstraction - polymorphisme - agrégation(association) - interface

            //Calcul de la surface d'un rectangle

            double hauteur = 10;
            double longueur = 20;

            Surface(hauteur, longueur);

            double hauteur2 = 15;
            double longueur2 = 20;

            Surface(hauteur2, longueur2);


            static double Surface(double h, double l)
            {
                return h * 1;
            }

            //Rectangle rec1 = new Rectangle();
            //rec1.Hauteur = 10;
            //rec1.Longueur = 10;
            //rec1.Surface();

            //Rectangle rec2 = new Rectangle();
            //rec2.Hauteur = 10;
            //rec2.Longueur = 10;
            //rec2.Surface();


            CompteBancaire cpt = new CompteBancaire(1225222, 1500);
            cpt.Depot(50000);
            cpt.Retrait(1000);

            CompteBancaire cpt2 = new CompteBancaire(588988);
            CompteBancaire cpt3 = new CompteBancaire();

            Console.WriteLine("Le CompteBancaire compte: " + CompteBancaire.compteur + " fois");

            Animal animal = new Animal();

            Chien a1 = new Chien();
            Chat a2 = new Chat();
            Animal a3 = new Animal("cdscds", 4);


            //Polyphormise objet prend autre objet sans avoir un type identique.
            Chat Chat2 = new Chat("monchat", 2);
            Console.WriteLine("Nbr d'objet de type chat: " + Chat.compteur);

            Console.WriteLine("Liste objet complexe List<Animals>");

            List<Animal> listAnimal = new List<Animal>();
            listAnimal.Add(new Chien());
            listAnimal.Add(new Chat()); 
            listAnimal.Add(new Animal());

            //Abstraction 

            Personne pPersonne = new Homme();
            pPersonne.Nom = "toto";


            //Interface

            //ProduitImpl pImpl = new ProduitImpl();
            //pImpl.FindById(5);

            //Agregation 
            Salarie salarie = new Salarie();
            Adresse adr = new Adresse { Numero = 10, Street = "Rue de Paris 75010"};

            salarie.Adr = adr;
            salarie.Nom = "Dawan";
            salarie.Salaire = 1000;

            #endregion





            //Maintenir la console ative
            Console.ReadKey();
        }
    }
}
