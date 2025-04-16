using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GestionnaireContacts
{
    public static class ContactManager
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();

        //Utilisation de AppData pour contact.json
        private static readonly string appDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "GestionContacts");
        private static readonly string filePath = Path.Combine(appDataPath, "contacts.json");

        public static void SauvegarderContacts()
        {
            string json = JsonSerializer.Serialize(Contacts, new JsonSerializerOptions { WriteIndented = true });

            if (!Directory.Exists(appDataPath))
            {
                Directory.CreateDirectory(appDataPath);
            }
            File.WriteAllText(filePath, json);
        }

        public static void ChargerContacts()
        {
            //Si fichier pas dans AppData
            if (!File.Exists(filePath))
            {
                // Copier le fichier initial depuis le dossier d'installation
                string installationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "contacts.json");

                //Si contact.json dans dossier installation alors copie
                if (File.Exists(installationFilePath))
                {
                    Directory.CreateDirectory(appDataPath); //Dossier stockage contacts.json
                    File.Copy(installationFilePath, filePath);
                }
            }

            // Charger les contacts à partir du fichier
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
        }
    }
}
