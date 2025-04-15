using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireContacts
{
    public class Contact
    {
        public required string Nom { get; set; }
        public required string Prenom { get; set; }
        public List<string> PrenomsEnfants { get; set; } = new List<string>();
    }
}
