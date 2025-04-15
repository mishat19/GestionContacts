﻿using System;
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
            confirmationWindow confirmation = new confirmationWindow();
            confirmation.Show();
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
                btnContact.Click += BtnContact_Click;

                flpContacts.Controls.Add(btnContact);
            }
        }

        private Contact contactSelectionne;

        private void BtnContact_Click(object sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is Contact contact)
            {
                textBoxNom.Text = contact.Nom;
                textBoxPrenom.Text = contact.Prenom;
                updDownElement.Value = contact.PrenomsEnfants.Count;

                // Mise à jour des TextBox enfants
                flpEnfants.Controls.Clear();

                for (int i = 0; i < contact.PrenomsEnfants.Count; i++)
                {
                    TextBox tb = new TextBox();
                    tb.Width = 150;
                    tb.Tag = "PrenomEnfant";
                    tb.Text = contact.PrenomsEnfants[i];
                    tb.PlaceholderText = $"Prénom enfant {i + 1}";

                    flpEnfants.Controls.Add(tb);
                }

                contactSelectionne = contact; // pour modifier plus tard
            }
        }


    }
}
