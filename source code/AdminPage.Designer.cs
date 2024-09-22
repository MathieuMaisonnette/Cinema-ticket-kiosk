namespace ProjetBorneCinema
{
    partial class AdminPage
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des 
        /// s utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonactualisateur = new System.Windows.Forms.Button();
            this.choixjour = new System.Windows.Forms.ComboBox();
            this.validjour = new System.Windows.Forms.Button();
            this.entermdp = new System.Windows.Forms.TextBox();
            this.ButtonFermeture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonactualisateur
            // 
            this.buttonactualisateur.Location = new System.Drawing.Point(186, 257);
            this.buttonactualisateur.Name = "buttonactualisateur";
            this.buttonactualisateur.Size = new System.Drawing.Size(219, 29);
            this.buttonactualisateur.TabIndex = 2;
            this.buttonactualisateur.Text = "reinitialisation complete";
            this.buttonactualisateur.UseVisualStyleBackColor = true;
            this.buttonactualisateur.Click += new System.EventHandler(this.buttonactualisateur_Click);
            // 
            // choixjour
            // 
            this.choixjour.FormattingEnabled = true;
            this.choixjour.Location = new System.Drawing.Point(29, 210);
            this.choixjour.Name = "choixjour";
            this.choixjour.Size = new System.Drawing.Size(151, 28);
            this.choixjour.TabIndex = 3;
            this.choixjour.SelectedIndexChanged += new System.EventHandler(this.choixjour_SelectedIndexChanged);
            // 
            // validjour
            // 
            this.validjour.Location = new System.Drawing.Point(186, 210);
            this.validjour.Name = "validjour";
            this.validjour.Size = new System.Drawing.Size(334, 29);
            this.validjour.TabIndex = 4;
            this.validjour.Text = "Cliquez pour actualiser les salles du jour choisi";
            this.validjour.UseVisualStyleBackColor = true;
            this.validjour.Click += new System.EventHandler(this.validjour_Click);
            // 
            // entermdp
            // 
            this.entermdp.Location = new System.Drawing.Point(88, 13);
            this.entermdp.Name = "entermdp";
            this.entermdp.Size = new System.Drawing.Size(432, 27);
            this.entermdp.TabIndex = 5;
            this.entermdp.TextChanged += new System.EventHandler(this.entermdp_TextChanged);
            // 
            // ButtonFermeture
            // 
            this.ButtonFermeture.BackColor = System.Drawing.Color.Red;
            this.ButtonFermeture.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonFermeture.Location = new System.Drawing.Point(147, 105);
            this.ButtonFermeture.Name = "ButtonFermeture";
            this.ButtonFermeture.Size = new System.Drawing.Size(297, 62);
            this.ButtonFermeture.TabIndex = 6;
            this.ButtonFermeture.Text = "Fermeture de l\'application";
            this.ButtonFermeture.UseVisualStyleBackColor = false;
            this.ButtonFermeture.Click += new System.EventHandler(this.ButtonFermeture_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.ButtonFermeture);
            this.Controls.Add(this.entermdp);
            this.Controls.Add(this.validjour);
            this.Controls.Add(this.choixjour);
            this.Controls.Add(this.buttonactualisateur);
            this.Name = "AdminPage";
            this.Size = new System.Drawing.Size(597, 313);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonactualisateur;
        private ComboBox choixjour;
        private Button validjour;
        private Button ButtonFermeture;
        public TextBox entermdp;
    }
}
