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
            //this.Text = "test";
            //labelMessageSysteme.Width = (WindowWidth - this.Text.Length) / 2;
        }

        //Pour centrer labelMessageSystem

        private void Form1_Resize(object sender, EventArgs e)
        {
            CentrerLabelMessage();
        }

        private void CentrerLabelMessage()
        {
            //Centrage horizontal
            labelMessageSysteme.Left = (this.ClientSize.Width - labelMessageSysteme.Width) / 2;
        }

        public void AfficherMessage(string message)
        {
            labelMessageSysteme.Text = message;
            CentrerLabelMessage();
        }

    }
}
