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
        private ListeContacts liste;
        public supprimerWindow(ListeContacts listContacts)
        {
            InitializeComponent();
            liste = listContacts;
            RafraichirListeContacts();
        }

        private void supprimerWindow_Load(object sender, EventArgs e)
        {
            btnSupprimerWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow(liste);
            ajout.Show();
            this.Close();
        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow(liste);
            modifier.Show();
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Form1 form = this.Owner as Form1;
            if (form != null)
            {
                confirmationWindow confirmation = new confirmationWindow();
                confirmation.Show(form);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RafraichirListeContacts()
        {
            // Définir la source de données
            lstContacts.DataSource = liste.MesContacts;

            // Définir les membres d'affichage et de valeur
            lstContacts.DisplayMember = "Nom"; // Affiche le nom du contact
            lstContacts.ValueMember = "Id";   // Utilise l'ID comme valeur
        }

        private void lstContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnVisualiser.Enabled = true;
        }

        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            if (lstContacts.SelectedItem is Contact contact)
            {
                txtNom.Text = contact.Nom;
                txtPrenom.Text = contact.Prenom;
                updElement.Value = contact.PrenomsEnfants!.Count;

                flpEnfants.Controls.Clear();

                if (contact.PrenomsEnfants != null && contact.PrenomsEnfants.Count > 0)
                {
                    foreach (string enfant in contact.PrenomsEnfants)
                    {
                        TextBox newTextBox = new TextBox
                        {
                            Name = $"txtEnfant{enfant}",
                            Text = enfant,
                            Width = 200
                        };
                        flpEnfants.Controls.Add(newTextBox);
                    }
                }
                txtNom.Enabled = true;
                txtPrenom.Enabled = true;
                updElement.Enabled = true;
            }
        }

        private void txtPrenom_TextChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = true;
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = true;
        }

        private void updElement_ValueChanged(object sender, EventArgs e)
        {
            btnSupprimer.Enabled = true;
        }
    }
}
