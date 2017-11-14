using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TroisiemeApplication.Model;

namespace TroisiemeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //LireXml();
            //string pathFichierClient = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Clients.xml");
            //LireXml(pathFichierClient);
            //EcrireXml(pathFichierClient, "Ipsum", "Lorem");

            string pathFichierClient = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientUnique.xml");
            SerialiserUnClient(pathFichierClient);
            DeserialiserUnClient(pathFichierClient);

            Console.ReadLine();
        }

        /// <summary>
        /// Premier exemple de lecture de XML
        /// </summary>
        static void LireXml()
        {
            XmlDocument xmlDoc = new XmlDocument();

            xmlDoc.LoadXml("<Client nom=\"Daniel\">Mon premier client</Client>");
            Console.WriteLine($"Noeud : {xmlDoc.DocumentElement.Name}");
            Console.WriteLine($"Valeur : {xmlDoc.DocumentElement.InnerText}");

            Console.WriteLine($"Attribut : {xmlDoc.DocumentElement.Attributes["nom"].Name}");
            Console.WriteLine($"Valeur : {xmlDoc.DocumentElement.Attributes["nom"].Value}");

            xmlDoc.LoadXml("<Client><Nom>Daniel</Nom><Prenom>Cedric</Prenom></Client>");
            Console.WriteLine($"Noeud : {xmlDoc.DocumentElement.Name}");
            Console.WriteLine($"Valeur : {xmlDoc.DocumentElement.InnerXml}");
        }

        /// <summary>
        /// Lecture du fichier XML dont le chemin est passé en paramètres
        /// </summary>
        /// <param name="cheminFichier">Chemin du fichier clients.xml</param>
        static void LireXml(string cheminFichier)
        {
            XmlDocument xmlDoc = new XmlDocument();
            // TODO : Vérifier l'existence du fichier
            xmlDoc.Load(cheminFichier);

            XmlNodeList clientNodes = xmlDoc.SelectNodes("//Clients/Client");
            foreach (XmlNode clientNode in clientNodes)
            {
                XmlNode nomClientNode = clientNode.SelectSingleNode("Nom");
                Console.WriteLine($"Noeud : {nomClientNode.Name}, valeur : {nomClientNode.InnerText}");

                XmlNode prenomClientNode = clientNode.SelectSingleNode("Prenom");
                Console.WriteLine($"Noeud : {prenomClientNode.Name}, valeur : {prenomClientNode.InnerText}");
            }
        }

        /// <summary>
        /// Ecriture d'un fichier xml dont le chemin est passé en paramètre
        /// </summary>
        /// <param name="cheminFichier">chemin du fichier à sauvegarder</param>
        /// <param name="nom">Nom du client</param>
        /// <param name="prenom">Prenom du client</param>
        static void EcrireXml(string cheminFichier, string nom, string prenom)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(cheminFichier);

            // Création du noeud pour le nouveau client
            XmlNode nouveauClientNode = xmlDoc.CreateElement("Client");

            // Créationn du noeud pour le nom du client
            XmlNode nomClientNode = xmlDoc.CreateElement("Nom");
            nomClientNode.InnerText = nom;
            // Ajout du noeud Nom au noeud Client
            nouveauClientNode.AppendChild(nomClientNode);

            // Créationn du noeud pour le prénom du client
            XmlNode prenomClientNode = xmlDoc.CreateElement("Prenom");
            prenomClientNode.InnerText = prenom;
            // Ajout du noeud Prenom au noeud Client
            nouveauClientNode.AppendChild(prenomClientNode);

            Console.WriteLine(nouveauClientNode.InnerXml);

            // Ajout du nouveau client à la racine de notre fichier XML
            xmlDoc.SelectSingleNode("Clients").AppendChild(nouveauClientNode);
            xmlDoc.Save(cheminFichier);

        }

        /// <summary>
        /// Sérialise un client en XML
        /// </summary>
        /// <param name="cheminFichier"></param>
        static void SerialiserUnClient(string cheminFichier)
        {
            Client client = new Model.Client() { Id = 100, Nom = "Daniel", Prenom = "Cedric", Commentaire = "<p>Client super <b>sympa</b></p>", DateNaissance = DateTime.Now };
            client.Factures.Add(new Facture() { NumeroFacture = "12345", Montant = 50.90 });
            client.Factures.Add(new Facture() { NumeroFacture = "67890", Montant = 124.90 });

            XmlSerializer xs = new XmlSerializer(typeof(Client));
            using (StreamWriter sw = new StreamWriter(cheminFichier))
            {
                xs.Serialize(sw, client);
            }
        }

        static void DeserialiserUnClient(string cheminFichier)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Client));
            using (StreamReader sr = new StreamReader(cheminFichier))
            {
                Client monClient = xs.Deserialize(sr) as Client;
                if(monClient != null)
                {
                    Console.WriteLine($"Nom : {monClient.Nom}");
                    Console.WriteLine($"Prenom : {monClient.Prenom}");
                }
            }
        }
    }
}
