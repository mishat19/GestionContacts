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
    public partial class ajoutWindow : Form
    {
        public ajoutWindow()
        {
            InitializeComponent();
        }

        private void ajoutWindow_Load(object sender, EventArgs e)
        {
            btnAjouterWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow();
            supprimer.Show();
            this.Close();
        }

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow();
            modifier.Show();
            this.Close();
        }

        private bool verifEnfants = false;
        //Récupérer le prénom de tous les enfants
        private List<string> GetPrenomsEnfants()
        {
            List<string> prenoms = new List<string>();
            foreach (Control ctrl in flpEnfants.Controls)
            {
                if (ctrl is TextBox tb)
                {
                    if (!string.IsNullOrEmpty(ctrl.Text))
                    {
                        verifEnfants = true;
                        prenoms.Add(ctrl.Text.Trim());
                    }
                }
            }
            return prenoms;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            var contact = new Contact
            {
                Nom = textBoxNom.Text,
                Prenom = textBoxPrenom.Text,
                PrenomsEnfants = GetPrenomsEnfants()
            };

            if (!string.IsNullOrWhiteSpace(contact.Nom) && !string.IsNullOrWhiteSpace(contact.Prenom) && verifEnfants != false) {
                ContactManager.Contacts.Add(contact);
                Form1 menu = new Form1();
                menu.Show();
                menu.labelMessageSysteme.Text = $"{contact.Prenom} {contact.Nom} a été ajouté";
                //MessageBox.Show($"{contact.Prenom} {contact.Nom} a été ajouté avec {contact.PrenomsEnfants.Count} enfant(s).");
                this.Close();
            } else MessageBox.Show("Veuillez entrer toutes les informations requises");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_TextChanged != null)
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void nudElement_ValueChanged(object sender, EventArgs e)
        {
            int nbEnfants = (int)updDownElement.Value;
            UpdateEnfantTextBoxes(nbEnfants);
        }

        private void UpdateEnfantTextBoxes(int nbEnfants)
        {
            // Supprimer les TextBox en trop
            while (flpEnfants.Controls.Count > nbEnfants)
            {
                flpEnfants.Controls.RemoveAt(flpEnfants.Controls.Count - 1);
            }

            // Ajouter les TextBox manquantes
            while (flpEnfants.Controls.Count < nbEnfants)
            {
                TextBox newTextBox = new TextBox
                {
                    Name = $"textBoxEnfant{nbEnfants}",
                    PlaceholderText = $"Prénom enfant{nbEnfants}",
                    Width = 200
                };
                flpEnfants.Controls.Add(newTextBox);
            }
        }
    }
}
