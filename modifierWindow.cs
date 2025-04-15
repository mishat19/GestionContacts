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
    public partial class modifierWindow : Form
    {
        public modifierWindow()
        {
            InitializeComponent();
            RafraichirListeContacts();
        }

        private void modifierWindow_Load(object sender, EventArgs e)
        {
            btnModifierWindow.Focus(); //Focus
        }

        private void btnAjouterWindow_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow();
            ajout.Show();
            this.Close();
        }

        private void btnSupprimerWindow_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow();
            supprimer.Show();
            this.Close();
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
                btnContact.Click += BtnContact_Click;

                flpContacts.Controls.Add(btnContact);
            }
        }

        private Contact contactSelectionne;
        private bool updEnfants;

        private void BtnContact_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Contact contact)
            {
                contactSelectionne = contact;

                textBoxNom.Text = contact.Nom;
                textBoxPrenom.Text = contact.Prenom;
                textBoxNom.TextChanged += ChampsModifies;
                textBoxPrenom.TextChanged += ChampsModifies;
                updDownElement.Value = contact.PrenomsEnfants.Count;
                updDownElement.ValueChanged += ChampsModifies;

                flpEnfants.Controls.Clear();

                    for (int i = 0; i < contact.PrenomsEnfants.Count; i++)
                    {
                        TextBox tb = new TextBox();
                        tb.Width = 150;
                        tb.Text = contact.PrenomsEnfants[i];
                        tb.Tag = "PrenomEnfant";
                        tb.PlaceholderText = $"Prénom enfant {i + 1}";
                        tb.TextChanged += ChampsModifies;

                        flpEnfants.Controls.Add(tb);
                    }

                textBoxNom.Enabled = true;
                textBoxPrenom.Enabled = true;
                updDownElement.Enabled = true;
            }
        }

        private bool verifEnfants = false;

        //Récupérer le prénom des enfants
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

        private void ChampsModifies(object sender, EventArgs e)
        {
            btnModifContact.Enabled = true;
        }


        private void btnModifierWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnModifContact_Click(object sender, EventArgs e)
        {
            if (contactSelectionne != null && !string.IsNullOrWhiteSpace(contactSelectionne.Nom) && !string.IsNullOrWhiteSpace(contactSelectionne.Prenom) && verifEnfants != false)
            {
                contactSelectionne.Nom = textBoxNom.Text;
                contactSelectionne.Prenom = textBoxPrenom.Text;
                contactSelectionne.PrenomsEnfants = GetPrenomsEnfants();

                Form1 menu = new Form1();
                menu.Show();
                menu.labelMessageSysteme.Text = $"{contactSelectionne.Prenom} {contactSelectionne.Nom} a été modifié";
                this.Close();
            } else MessageBox.Show("Veuillez entrer toutes les informations requises");
        }

        private void updDownElement_ValueChanged(object sender, EventArgs e)
        {
            int nbEnfantsVoulu = (int)updDownElement.Value;
            int nbActuel = flpEnfants.Controls.Count;

            if (nbEnfantsVoulu > nbActuel)
            {
                // Ajouter des enfants
                for (int i = nbActuel; i < nbEnfantsVoulu; i++)
                {
                    TextBox tb = new TextBox();
                    tb.Width = 150;
                    tb.Tag = "PrenomEnfant";
                    tb.PlaceholderText = $"Prénom enfant {i + 1}";
                    tb.TextChanged += ChampsModifies;
                    flpEnfants.Controls.Add(tb);
                }
            }
            else if (nbEnfantsVoulu < nbActuel)
            {
                // Supprimer les derniers enfants
                for (int i = nbActuel - 1; i >= nbEnfantsVoulu; i--)
                {
                    flpEnfants.Controls.RemoveAt(i);
                }

                btnModifContact.Enabled = true;
            }
        }
    }
}
