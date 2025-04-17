namespace FormNomExplicite
{
    using GestionnaireContacts;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize!;
            ContactManager.ChargerContacts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelMessageSysteme.Text = "";
            CentrerLabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAjout_Click(object sender, EventArgs e)
        {
            ajoutWindow ajout = new ajoutWindow();
            ajout.Show();
            this.Hide();
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            supprimerWindow supprimer = new supprimerWindow();
            supprimer.Show();
            this.Hide();
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            modifierWindow modifier = new modifierWindow();
            modifier.Show();

            this.Hide();
        }

        private void labelMessageSysteme_Click_1(object sender, EventArgs e)
        {
        }

        private void CentrerLabel()
        {
            labelMessageSysteme.Left = (this.ClientSize.Width - labelMessageSysteme.Width) / 2;
            labelTitre.Left = (this.ClientSize.Width - labelTitre.Width) / 2;
            buttonAjout.Left = (this.ClientSize.Width - buttonAjout.Width) / 2;
            buttonSupprimer.Left = (this.ClientSize.Width - buttonSupprimer.Width) / 2;
            buttonModifier.Left = (this.ClientSize.Width - buttonModifier.Width) / 2;
        }


        //Pour centrer labelMessageSystem

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentrerLabel();
        }

        public void AfficherMessage(string message)
        {
            labelMessageSysteme.Text = message;
            CentrerLabel();
        }

        private void btnImporter_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fichier JSON (*.json)|*.json";
            openFileDialog.Title = "Sélectionner un fichier contacts.json";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Assurer que le dossier AppData existe
                    if (!Directory.Exists(ContactManager.appDataPath))
                        Directory.CreateDirectory(ContactManager.appDataPath);

                    //Copie et remplaçage si existence
                    File.Copy(openFileDialog.FileName, ContactManager.filePath, overwrite: true);

                    MessageBox.Show("Importation réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Charger fichier importé
                    ContactManager.ChargerContacts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'importation :\n{ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
