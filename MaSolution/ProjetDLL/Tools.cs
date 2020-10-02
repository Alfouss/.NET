using ProjetDLL.Encapsulation;
using ProjetDLL.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace ProjetDLL
{
    public class Tools
    {

        public string Chemin { get; set; }
        public string Fichier { get; set; }


        //Méthode qui permet d'ecrire dans un fichier

        public static void EcrireFile(string chemin, string contenu)
        {

            StreamWriter ecriture = new StreamWriter(chemin);
            ecriture.WriteLine(contenu);
            ecriture.Close();
        }


        public static string LireFile(string chemin)
        {
            string contenu = null;

            if (File.Exists(chemin))
            {
                StreamReader ecriture = new StreamReader(chemin);
                ecriture.ReadToEnd();
                ecriture.Close();
            }
            else
            {
                throw new FichierIntrouvableException("Fichier introuvable");
            }

            return contenu;


        }


        //Méthode de sérialisation d'un liste de compte bancaire

        public static void ExportBin(string path, List<CompteBancaire> list){

            //Créer le flux et changer le fichier dessus
            FileStream fs = new FileStream(path, FileMode.Create);

            //Créer le binFormatter pour la sérialisation
            BinaryFormatter bf = new BinaryFormatter();

            //Sérialisation de la liste de compte dans les fichier
            bf.Serialize(fs, list);

            //Fermeture du fichier
            fs.Close();
        }

        //Méthode de désérialisation d'un fichier binaire

        public static List<CompteBancaire> ImportBin(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();
            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();

                list = (List<CompteBancaire>)bf.Deserialize(fs);
                fs.Close();
            }
            else
            {
                throw new FichierIntrouvableException("Fichier Serialisé non trouvé");
            }

            return list;

        }

        //Méthode de sérialisation XML

        public static void ExportXML(string path, List<CompteBancaire> list)
        {
            //Créer le flux du fichier

            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer serializ = new XmlSerializer(list.GetType());

            serializ.Serialize(fs, list);
            fs.Close();


        }

        //Méthode de désérialisation XML 

        public static List<CompteBancaire> ImportXml(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();

            if (File.Exists(path))
            {
                FileStream fs = new FileStream(path, FileMode.Open);
                XmlSerializer serialize = new XmlSerializer(list.GetType());
                list = (List<CompteBancaire>)serialize.Deserialize(fs);
                fs.Close();
            }
            else
            {
                throw new FichierIntrouvableException("Fichier XML introuvable");
            }
            return list;
        }

        //Export csv

        public static void ExportCSV(string path, List<CompteBancaire> list) {
            StreamWriter sw = new StreamWriter(path);

            foreach (var cpt in list)
            {
                sw.WriteLine(cpt.Numero + "," + cpt.Solde );
            }

            sw.Close();
        }

        public static List<CompteBancaire> ImportCSV(string path)
        {
            List<CompteBancaire> list = new List<CompteBancaire>();

            StreamReader sr = new StreamReader(path);

            if (File.Exists(path))
            {
                while (!sr.EndOfStream)
                {
                    string ligne = sr.ReadLine();
                    ligne = ligne.Trim();

                    if (!ligne.Equals(""))
                    {
                        string[] tab = ligne.Split(',');
                        CompteBancaire cpt = new CompteBancaire(int.Parse(tab[0]), double.Parse(tab[1]));

                        //Insérer l'objet dans la liste de compte
                        list.Add(cpt);
                    }
                }
                sr.Close();
            }
            else
            {
                throw new FichierIntrouvableException("Fichier CSV introuvable");
            }


            return list;
        }

    }

}
