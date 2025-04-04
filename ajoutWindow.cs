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
        private Dictionary<int, TextBox> enfantTextBoxes;
        public ajoutWindow()
        {
            InitializeComponent();
            enfantTextBoxes = new Dictionary<int, TextBox>();
            updDownElement.ValueChanged += udElement_ValueChanged!;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void udElement_ValueChanged(object sender, EventArgs e)
        {
            int newCount = (int)updDownElement.Value;
            UpdateEnfantTextBoxes(newCount);
        }

        private void UpdateEnfantTextBoxes(int newCount)
        {
            // Supprimer les TextBox en trop
            while (enfantTextBoxes.Count > newCount)
            {
                int keyToRemove = enfantTextBoxes.Keys.Max();
                flpEnfants.Controls.Remove(enfantTextBoxes[keyToRemove]);
                enfantTextBoxes[keyToRemove].Dispose();
                enfantTextBoxes.Remove(keyToRemove);
            }

            // Ajouter les TextBox manquantes
            for (int i = enfantTextBoxes.Count + 1; i <= newCount; i++)
            {
                TextBox newTextBox = new TextBox
                {
                    Name = $"textBoxEnfant{i}",
                    PlaceholderText = $"Prénom enfant{i}",
                    Width = 200
                };
                flpEnfants.Controls.Add(newTextBox);
                enfantTextBoxes[i] = newTextBox;
            }
        }
    }
}
