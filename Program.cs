using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace AT11_Exemple
{
    class Program
    {
        static void Main(string[] args)
        {
            Adresse ad = new Adresse() { pays = "Maroc", ville = "Marrakech", rue = "Nahda" };
            Etudiant ed = new Etudiant() { numins = 2, nom = "Mazzouz", prenom = "Chaimae", adresse = ad };
            Etudiant ed2 = new Etudiant() { numins = 3, nom = "Mazzouz", prenom = "Ayman", adresse = ad };
            Etudiant ed3 = new Etudiant() { numins = 4, nom = "Alaoui", prenom = "Chaimae", adresse = ad };
            //Stream file = File.Create(@"C:\Users\user\Desktop\Etudiant.txt");
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(file, ed);
            //file.Close();
            //Console.WriteLine("Sérialisation terminée avec succés");
            //Console.ReadKey();

            //Etudiant ed2;
            //Stream f = File.OpenRead(@"C:\Users\user\Desktop\Etudiant.txt");
            //BinaryFormatter bf2 = new BinaryFormatter();
            //ed2 = (Etudiant)bf2.Deserialize(f);
            //Console.WriteLine(ed2);
            //Console.ReadKey();

            //Stream file = File.Create(@"C:\Users\user\Desktop\Etudiant.xml");
            //XmlSerializer bf = new XmlSerializer(typeof(Etudiant));
            //bf.Serialize(file,ed) ;
            //file.Close();
            //Console.WriteLine("Sérialisation terminée avec succés");
            //Console.ReadKey();

            //Etudiant ed2;
            //Stream f = File.OpenRead(@"C:\Users\user\Desktop\Etudiant.xml");
            //XmlSerializer bf2 = new XmlSerializer(typeof(Etudiant));
            //ed2 = (Etudiant)bf2.Deserialize(f);
            //Console.WriteLine(ed2);
            //Console.ReadKey();

            //List<Etudiant> LE = new List<Etudiant>();
            //LE.Add(ed);
            //LE.Add(ed2);
            //LE.Add(ed3);
            //Stream file = File.Create(@"C:\Users\user\Desktop\Etudiant2.xml");
            //XmlSerializer bf = new XmlSerializer(typeof(List<Etudiant>));
            //bf.Serialize(file, LE);
            //file.Close();
            //Console.WriteLine("Sérialisation terminée avec succés");
            //Console.ReadKey();


            List<Etudiant> LE2 = new List<Etudiant>();
            Stream f = File.OpenRead(@"C:\Users\user\Desktop\Etudiant2.xml");
            XmlSerializer bf2 = new XmlSerializer(typeof(List<Etudiant>));
            LE2 = (List<Etudiant>)bf2.Deserialize(f);
            foreach(Etudiant e in LE2)
              Console.WriteLine(e);
            Console.ReadKey();

        }
    }
}
