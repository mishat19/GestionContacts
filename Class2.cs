using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GestionnaireContacts
{
    public static class ContactManager
    {
        public static List<Contact> Contacts { get; set; } = new List<Contact>();
        private static readonly string filePath = "contacts.json";

        public static void SauvegarderContacts()
        {
            string json = JsonSerializer.Serialize(Contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static void ChargerContacts()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Contacts = JsonSerializer.Deserialize<List<Contact>>(json) ?? new List<Contact>();
            }
        }
    }
}
