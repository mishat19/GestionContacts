namespace FormNomExplicite
{
    partial class modifierWindow
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
            btnModifContact = new Button();
            labelContacts = new Label();
            flpContacts = new FlowLayoutPanel();
            labelPrenoms = new Label();
            flpEnfants = new FlowLayoutPanel();
            updDownElement = new NumericUpDown();
            textBoxNom = new TextBox();
            textBoxPrenom = new TextBox();
            ((System.ComponentModel.ISupportInitialize)updDownElement).BeginInit();
            SuspendLayout();
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Enabled = false;
            btnModifierWindow.Location = new Point(230, 12);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 5;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Location = new Point(122, 12);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 4;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Location = new Point(14, 12);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 3;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnModifContact
            // 
            btnModifContact.Enabled = false;
            btnModifContact.Location = new Point(600, 392);
            btnModifContact.Name = "btnModifContact";
            btnModifContact.Size = new Size(138, 29);
            btnModifContact.TabIndex = 9;
            btnModifContact.Text = "Modifier contact";
            btnModifContact.UseVisualStyleBackColor = true;
            btnModifContact.Click += btnModifContact_Click;
            // 
            // labelContacts
            // 
            labelContacts.AutoSize = true;
            labelContacts.Location = new Point(19, 148);
            labelContacts.Name = "labelContacts";
            labelContacts.Size = new Size(141, 20);
            labelContacts.TabIndex = 32;
            labelContacts.Text = "Noms des contacts :";
            // 
            // flpContacts
            // 
            flpContacts.AutoScroll = true;
            flpContacts.Location = new Point(19, 171);
            flpContacts.Name = "flpContacts";
            flpContacts.Size = new Size(218, 132);
            flpContacts.TabIndex = 31;
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(531, 148);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 30;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Location = new Point(531, 171);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 29;
            // 
            // updDownElement
            // 
            updDownElement.Enabled = false;
            updDownElement.Location = new Point(447, 276);
            updDownElement.Name = "updDownElement";
            updDownElement.Size = new Size(45, 27);
            updDownElement.TabIndex = 28;
            updDownElement.ValueChanged += updDownElement_ValueChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Enabled = false;
            textBoxNom.Location = new Point(259, 211);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.PlaceholderText = "Saisir nom";
            textBoxNom.Size = new Size(233, 27);
            textBoxNom.TabIndex = 27;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Enabled = false;
            textBoxPrenom.Location = new Point(259, 166);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.PlaceholderText = "Saisir prénom";
            textBoxPrenom.Size = new Size(233, 27);
            textBoxPrenom.TabIndex = 26;
            // 
            // modifierWindow
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
            Controls.Add(btnModifContact);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "modifierWindow";
            Text = "Modifier Contact";
            Load += modifierWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updDownElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModifierWindow;
        private Button btnSupprimerWindow;
        private Button btnAjouterWindow;
        private Button btnModifContact;
        private Label labelContacts;
        private FlowLayoutPanel flpContacts;
        private Label labelPrenoms;
        private FlowLayoutPanel flpEnfants;
        private NumericUpDown updDownElement;
        private TextBox textBoxNom;
        private TextBox textBoxPrenom;
    }
}