using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireContacts
{
    public class Contact
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public List<string> PrenomsEnfants { get; set; } = new List<string>();
    }
}
