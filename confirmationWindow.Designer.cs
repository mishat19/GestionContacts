namespace FormNomExplicite
{
    partial class confirmationWindow
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
            btnConfirmer = new Button();
            btnAnnuler = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnConfirmer
            // 
            btnConfirmer.Location = new Point(339, 163);
            btnConfirmer.Name = "btnConfirmer";
            btnConfirmer.Size = new Size(94, 29);
            btnConfirmer.TabIndex = 0;
            btnConfirmer.Text = "Confirmer";
            btnConfirmer.UseVisualStyleBackColor = true;
            btnConfirmer.Click += btnConfirmer_Click;
            // 
            // btnAnnuler
            // 
            btnAnnuler.Location = new Point(439, 163);
            btnAnnuler.Name = "btnAnnuler";
            btnAnnuler.Size = new Size(94, 29);
            btnAnnuler.TabIndex = 1;
            btnAnnuler.Text = "Annuler";
            btnAnnuler.UseVisualStyleBackColor = true;
            btnAnnuler.Click += btnAnnuler_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 92);
            label1.Name = "label1";
            label1.Size = new Size(305, 20);
            label1.TabIndex = 2;
            label1.Text = "Voulez-vous vraiment supprimer ce contact ?";
            // 
            // confirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 253);
            Controls.Add(label1);
            Controls.Add(btnAnnuler);
            Controls.Add(btnConfirmer);
            Name = "confirmation";
            Text = "Confirmation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirmer;
        private Button btnAnnuler;
        private Label label1;
    }
}