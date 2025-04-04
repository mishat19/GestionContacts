using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            string prenom = textBoxPrenom.Text;
            Console.WriteLine(prenom);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1_TextChanged != null)
            {
                btnEnregistrer.Enabled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudElement_ValueChanged(object sender, EventArgs e)
        {
            int nbEnfants = (int)updDownElement.Value;
            UpdateEnfantTextBoxes(nbEnfants);
        }

        private void UpdateEnfantTextBoxes(int nbEnfants)
        {
            // Supprimer les TextBox en trop
            while(flpEnfants.Controls.Count > nbEnfants)
            {
                flpEnfants.Controls.RemoveAt(flpEnfants.Controls.Count-1);
            }

            // Ajouter les TextBox manquantes
            while(flpEnfants.Controls.Count < nbEnfants)
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
