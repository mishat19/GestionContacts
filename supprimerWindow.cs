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
    public partial class supprimerWindow : Form
    {
        public supprimerWindow()
        {
            InitializeComponent();
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
    }
}
