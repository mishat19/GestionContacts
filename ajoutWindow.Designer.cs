namespace FormNomExplicite
{
    partial class ajoutWindow
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
            btnAjouterWindow = new Button();
            btnSupprimerWindow = new Button();
            btnModifierWindow = new Button();
            btnEnregistrer = new Button();
            textBoxPrenom = new TextBox();
            textBoxNom = new TextBox();
            updDownElement = new NumericUpDown();
            flpEnfants = new FlowLayoutPanel();
            labelPrenoms = new Label();
            ((System.ComponentModel.ISupportInitialize)updDownElement).BeginInit();
            SuspendLayout();
            // 
            // btnAjouterWindow
            // 
            btnAjouterWindow.Enabled = false;
            btnAjouterWindow.Location = new Point(12, 22);
            btnAjouterWindow.Name = "btnAjouterWindow";
            btnAjouterWindow.Size = new Size(102, 38);
            btnAjouterWindow.TabIndex = 0;
            btnAjouterWindow.Text = "Ajouter";
            btnAjouterWindow.UseVisualStyleBackColor = true;
            btnAjouterWindow.Click += btnAjouterWindow_Click;
            // 
            // btnSupprimerWindow
            // 
            btnSupprimerWindow.Location = new Point(120, 22);
            btnSupprimerWindow.Name = "btnSupprimerWindow";
            btnSupprimerWindow.Size = new Size(102, 38);
            btnSupprimerWindow.TabIndex = 1;
            btnSupprimerWindow.Text = "Supprimer";
            btnSupprimerWindow.UseVisualStyleBackColor = true;
            btnSupprimerWindow.Click += btnSupprimerWindow_Click;
            // 
            // btnModifierWindow
            // 
            btnModifierWindow.Location = new Point(228, 22);
            btnModifierWindow.Name = "btnModifierWindow";
            btnModifierWindow.Size = new Size(102, 38);
            btnModifierWindow.TabIndex = 2;
            btnModifierWindow.Text = "Modifier";
            btnModifierWindow.UseVisualStyleBackColor = true;
            btnModifierWindow.Click += btnModifierWindow_Click;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Enabled = false;
            btnEnregistrer.Location = new Point(663, 369);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(102, 38);
            btnEnregistrer.TabIndex = 3;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            btnEnregistrer.Click += button1_Click;
            // 
            // textBoxPrenom
            // 
            textBoxPrenom.Location = new Point(120, 171);
            textBoxPrenom.Name = "textBoxPrenom";
            textBoxPrenom.PlaceholderText = "Saisir prénom";
            textBoxPrenom.Size = new Size(339, 27);
            textBoxPrenom.TabIndex = 5;
            textBoxPrenom.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNom
            // 
            textBoxNom.Location = new Point(120, 216);
            textBoxNom.Name = "textBoxNom";
            textBoxNom.PlaceholderText = "Saisir nom";
            textBoxNom.Size = new Size(339, 27);
            textBoxNom.TabIndex = 8;
            textBoxNom.TextChanged += textBox4_TextChanged;
            // 
            // updDownElement
            // 
            updDownElement.Location = new Point(406, 281);
            updDownElement.Name = "updDownElement";
            updDownElement.Size = new Size(45, 27);
            updDownElement.TabIndex = 11;
            updDownElement.ValueChanged += udElement_ValueChanged;
            // 
            // flpEnfants
            // 
            flpEnfants.AutoScroll = true;
            flpEnfants.Location = new Point(515, 176);
            flpEnfants.Name = "flpEnfants";
            flpEnfants.Size = new Size(250, 132);
            flpEnfants.TabIndex = 12;
            // 
            // labelPrenoms
            // 
            labelPrenoms.AutoSize = true;
            labelPrenoms.Location = new Point(515, 153);
            labelPrenoms.Name = "labelPrenoms";
            labelPrenoms.Size = new Size(152, 20);
            labelPrenoms.TabIndex = 13;
            labelPrenoms.Text = "Prénoms des enfants :";
            // 
            // ajoutWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPrenoms);
            Controls.Add(flpEnfants);
            Controls.Add(updDownElement);
            Controls.Add(textBoxNom);
            Controls.Add(textBoxPrenom);
            Controls.Add(btnEnregistrer);
            Controls.Add(btnModifierWindow);
            Controls.Add(btnSupprimerWindow);
            Controls.Add(btnAjouterWindow);
            Name = "ajoutWindow";
            Text = "Ajouter Contact";
            Load += ajoutWindow_Load;
            ((System.ComponentModel.ISupportInitialize)updDownElement).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAjouterWindow;
        private Button btnSupprimerWindow;
        private Button btnModifierWindow;
        private Button btnEnregistrer;
        private TextBox textBoxPrenom;
        private TextBox textBoxNom;
        private NumericUpDown updDownElement;
        private FlowLayoutPanel flpEnfants;
        private Label labelPrenoms;
    }
}