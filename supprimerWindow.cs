using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioContacts;

namespace FormNomExplicite
{
    public partial class supprimerWindow : Form
    {
        private ListeContacts L;
        public supprimerWindow(ListeContacts listContacts)
        {
            InitializeComponent();
            RafraichirListeContacts();
        }

        private void supprimerWindow_Load(object sender, EventArgs e)
        {
            btnSupprimerWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow();
            ajout.Show();
            this.Close();
        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow();
            modifier.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            confirmationWindow confirmation = new confirmationWindow();
            confirmation.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RafraichirListeContacts()
        {
            // Définir la source de données
            lstContacts.DataSource = L.MesContacts;

            // Définir les membres d'affichage et de valeur
            lstContacts.DisplayMember = "Nom"; // Affiche le nom du contact
            lstContacts.ValueMember = "Id";   // Utilise l'ID comme valeur
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstContacts.DisplayMember = "Nom";
            lstContacts.ValueMember = "Id";
        }

        private void btnVisualiser_Click(object sender, EventArgs e)
        {

        }
    }
}
