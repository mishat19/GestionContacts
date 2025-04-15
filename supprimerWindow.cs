using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionnaireContacts;
using static FormNomExplicite.Form1;

namespace FormNomExplicite
{
    public partial class supprimerWindow : Form
    {
        public supprimerWindow()
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
            if (contactASupprimer != null)
            {
                confirmationWindow confirmation = new confirmationWindow(contactASupprimer);
                confirmation.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RafraichirListeContacts()
        {
            flpContacts.Controls.Clear();

            foreach (var contact in ContactManager.Contacts)
            {
                Button btnContact = new Button();
                btnContact.Text = $"{contact.Prenom} {contact.Nom}";
                btnContact.Tag = contact;
                btnContact.Width = flpContacts.Width - 20; // pour bien remplir le panel
                btnContact.Height = 30;
                btnContact.Click += activationVisualisation!;
                flpContacts.Controls.Add(btnContact);
            }
        }

        private Contact contactSelectionne;

        private void activationVisualisation(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Contact contact)
            {
                contactSelectionne = contact; //stockage du contact à visualiser
                btnVisualiser.Enabled = true;
                btnSupprimer.Enabled = true;
                contactASupprimer = contactSelectionne;
            }
        }

        private Contact contactASupprimer;

        private void btnVisualiser_Click(object sender, EventArgs e)
        {
            if (contactSelectionne != null)
            {
                textBoxNom.Text = contactSelectionne.Nom;
                textBoxPrenom.Text = contactSelectionne.Prenom;
                updDownElement.Value = contactSelectionne.PrenomsEnfants.Count;

                flpEnfants.Controls.Clear();

                for (int i = 0; i < contactSelectionne.PrenomsEnfants.Count; i++)
                {
                    TextBox tb = new TextBox();
                    tb.Width = 150;
                    tb.Text = contactSelectionne.PrenomsEnfants[i];
                    tb.ReadOnly = true;
                    flpEnfants.Controls.Add(tb);
                }

                //contactASupprimer = contactSelectionne;
                btnVisualiser.Enabled = false;
            }
        }

    }
}
