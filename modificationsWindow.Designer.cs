namespace FormNomExplicite
{
    partial class modificationsWindow
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
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            btnEnregistrer = new Button();
            SuspendLayout();
            // 
            // textBox4
            // 
            textBox4.Location = new Point(231, 147);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Saisir nom";
            textBox4.Size = new Size(339, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(231, 252);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Saisir prénom enfant1";
            textBox3.Size = new Size(339, 27);
            textBox3.TabIndex = 12;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(231, 199);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Saisir nombre d'enfants (facultatif)";
            textBox2.Size = new Size(339, 27);
            textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(231, 98);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Saisir prénom";
            textBox1.Size = new Size(339, 27);
            textBox1.TabIndex = 10;
            // 
            // btnEnregistrer
            // 
            btnEnregistrer.Enabled = false;
            btnEnregistrer.Location = new Point(349, 315);
            btnEnregistrer.Name = "btnEnregistrer";
            btnEnregistrer.Size = new Size(102, 38);
            btnEnregistrer.TabIndex = 9;
            btnEnregistrer.Text = "Enregistrer";
            btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // modificationsWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnEnregistrer);
            Name = "modificationsWindow";
            Text = "Modifier Contact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnEnregistrer;
    }
}