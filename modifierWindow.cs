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
    public partial class modifierWindow : Form
    {
        public modifierWindow()
        {
            InitializeComponent();
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

        private void btnModifierWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnModifContact_Click(object sender, EventArgs e)
        {
            
        }
    }
}
