namespace FormNomExplicite
{
    partial class supprimerWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnModifierWindow = new Button();
            btnSupprimerWindow = new Button();
            btnAjouterWindow = new Button();
            btnSupprimer = new Button();
            btnVisualiser = new Button();
            textBoxNom = new TextBox();
            textBoxPrenom = new TextBox();
            updDownElement = new NumericUpDown();
            flpContacts = new FlowLayoutPanel();
            labelContacts = new Label();
            labelPrenoms = new Label();
            flpEnfants = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)updDownElement).BeginInit();
            SuspendLayout();
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Location = new Point(223, 12);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 5;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Enabled = false;
            btnSupprimerWindow.Location = new Point(115, 12);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 4;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Location = new Point(7, 12);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 3;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(654, 385);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(102, 38);
            btnSupprimer.TabIndex = 6;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnVisualiser
            // 
            btnVisualiser.Enabled = false;
            btnVisualiser.Location = new Point(29, 313);
            btnVisualiser.Name = "btnVisualiser";
            btnVisualiser.Size = new Size(188, 29);
            btnVisualiser.TabIndex = 16;
            btnVisualiser.Text = "Visualiser";
            btnVisualiser.UseVisualStyleBackColor = true;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(252, 204);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.PlaceholderText = "Saisir nom";
            textBoxNom.Size = new Size(233, 27);
            textBoxNom.TabIndex = 20;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(252, 159);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.PlaceholderText = "Saisir prénom";
            textBoxPrenom.Size = new Size(233, 27);
            textBoxPrenom.TabIndex = 19;
            // 
            // updDownElement
            // 
            updDownElement.Location = new Point(440, 269);
            updDownElement.Name = "updDownElement";
            updDownElement.Size = new Size(45, 27);
            updDownElement.TabIndex = 21;
            // 
            // flpContacts
            // 
            flpContacts.AutoScroll = true;
            flpContacts.Location = new Point(12, 164);
            flpContacts.Name = "flpContacts";
            flpContacts.Size = new Size(218, 132);
            flpContacts.TabIndex = 24;
            // 
            // labelContacts
            // 
            labelContacts.AutoSize = true;
            labelContacts.Location = new Point(12, 141);
            labelContacts.Name = "labelContacts";
            labelContacts.Size = new Size(141, 20);
            labelContacts.TabIndex = 25;
            labelContacts.Text = "Noms des contacts :";
            labelContacts.Click += label1_Click;
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(524, 141);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 23;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Enabled = false;
            flpEnfants.Location = new Point(524, 164);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 22;
            // 
            // supprimerWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelContacts);
            Controls.Add(flpContacts);
            Controls.Add(labelPrenoms);
            Controls.Add(flpEnfants);
            Controls.Add(updDownElement);
            Controls.Add(textBoxNom);
            Controls.Add(textBoxPrenom);
            Controls.Add(btnVisualiser);
            Controls.Add(btnSupprimer);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "supprimerWindow";
            Text = "Supprimer Contact";
            Load += supprimerWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updDownElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifierWindow;
        private Button btnSupprimerWindow;
        private Button btnAjouterWindow;
        private Button btnSupprimer;
        private Button btnVisualiser;
        private TextBox textBoxNom;
        private TextBox textBoxPrenom;
        private NumericUpDown updDownElement;
        private FlowLayoutPanel flpContacts;
        private Label labelContacts;
        private Label labelPrenoms;
        private FlowLayoutPanel flpEnfants;
    }
}