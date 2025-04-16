using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FormNomExplicite.Form1;
using GestionnaireContacts;

namespace FormNomExplicite
{
    public partial class confirmationWindow : Form
    {
        private Contact contact;
        private supprimerWindow fenetreSuppression;

        public confirmationWindow(Contact contactASupprimer, supprimerWindow fenetre)
        {
            InitializeComponent();
            this.contact = contactASupprimer;
            this.fenetreSuppression = fenetre;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            ContactManager.Contacts.Remove(contact);
            ContactManager.SauvegarderContacts(); //Sauvegarder du contact dans mon JSON
            Form1 menu = new Form1();
            menu.Show();
            menu.AfficherMessage($"Le contact {contact.Prenom} {contact.Nom} a été supprimé");
            this.Close();
            fenetreSuppression.Close();
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
