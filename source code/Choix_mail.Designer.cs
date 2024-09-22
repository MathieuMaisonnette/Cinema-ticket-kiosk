namespace ProjetBorneCinema
{
    partial class Choix_mail
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
            this.buttonvalider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxmail = new System.Windows.Forms.CheckBox();
            this.checkBoximpr = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonvalider
            // 
            this.buttonvalider.Location = new System.Drawing.Point(270, 232);
            this.buttonvalider.Name = "buttonvalider";
            this.buttonvalider.Size = new System.Drawing.Size(134, 54);
            this.buttonvalider.TabIndex = 10;
            this.buttonvalider.Text = "Valider";
            this.buttonvalider.UseVisualStyleBackColor = true;
            this.buttonvalider.Click += new System.EventHandler(this.buttonvalider_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(369, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 43);
            this.textBox1.TabIndex = 9;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Click += new System.EventHandler(this.textBox1_click);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBoxmail
            // 
            this.checkBoxmail.AutoSize = true;
            this.checkBoxmail.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxmail.Location = new System.Drawing.Point(219, 156);
            this.checkBoxmail.Name = "checkBoxmail";
            this.checkBoxmail.Size = new System.Drawing.Size(92, 42);
            this.checkBoxmail.TabIndex = 8;
            this.checkBoxmail.Text = "Mail";
            this.checkBoxmail.UseVisualStyleBackColor = true;
            this.checkBoxmail.CheckedChanged += new System.EventHandler(this.checkBoxmail_CheckedChanged);
            // 
            // checkBoximpr
            // 
            this.checkBoximpr.AutoSize = true;
            this.checkBoximpr.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoximpr.Location = new System.Drawing.Point(34, 154);
            this.checkBoximpr.Name = "checkBoximpr";
            this.checkBoximpr.Size = new System.Drawing.Size(152, 42);
            this.checkBoximpr.TabIndex = 7;
            this.checkBoximpr.Text = "Imprimer";
            this.checkBoximpr.UseVisualStyleBackColor = true;
            this.checkBoximpr.CheckedChanged += new System.EventHandler(this.checkBoximpr_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choix_mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Controls.Add(this.buttonvalider);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBoxmail);
            this.Controls.Add(this.checkBoximpr);
            this.Controls.Add(this.label1);
            this.Name = "Choix_mail";
            this.Size = new System.Drawing.Size(700, 300);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonvalider;
        private TextBox textBox1;
        private CheckBox checkBoxmail;
        private CheckBox checkBoximpr;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Label label2;
    }
}
