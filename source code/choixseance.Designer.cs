namespace ProjetBorneCinema
{
    partial class choixseance
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
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
            this.buttonprecedent = new confiserie.RoundedButton();
            this.SuspendLayout();
            // 
            // buttonprecedent
            // 
            this.buttonprecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.buttonprecedent.FlatAppearance.BorderSize = 0;
            this.buttonprecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonprecedent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonprecedent.Location = new System.Drawing.Point(10, 10);
            this.buttonprecedent.Name = "buttonprecedent";
            this.buttonprecedent.Size = new System.Drawing.Size(120, 60);
            this.buttonprecedent.TabIndex = 1;
            this.buttonprecedent.Text = "Précédent";
            this.buttonprecedent.UseVisualStyleBackColor = false;
            this.buttonprecedent.Click += new System.EventHandler(this.buttonprecedent_Click);
            // 
            // choixseance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonprecedent);
            this.Name = "choixseance";
            this.Size = new System.Drawing.Size(1595, 931);
            this.ResumeLayout(false);

        }

        #endregion

        private confiserie.RoundedButton buttonprecedent;
    }
}
