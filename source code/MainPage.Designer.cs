namespace ProjetBorneCinema
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.logocinema = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Validationfinale = new System.Windows.Forms.Button();
            this.titrepanier = new System.Windows.Forms.Label();
            this.nomcinema = new System.Windows.Forms.Label();
            this.buttonconfiserie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.state1 = new ProjetBorneCinema.confiserie.RoundedButton();
            this.state4 = new ProjetBorneCinema.confiserie.RoundedButton();
            this.state3 = new ProjetBorneCinema.confiserie.RoundedButton();
            this.state2 = new ProjetBorneCinema.confiserie.RoundedButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logocinema)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // logocinema
            // 
            this.logocinema.Image = ((System.Drawing.Image)(resources.GetObject("logocinema.Image")));
            this.logocinema.Location = new System.Drawing.Point(76, 4);
            this.logocinema.Name = "logocinema";
            this.logocinema.Size = new System.Drawing.Size(186, 93);
            this.logocinema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logocinema.TabIndex = 3;
            this.logocinema.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.panel6.Controls.Add(this.Validationfinale);
            this.panel6.Controls.Add(this.titrepanier);
            this.panel6.Location = new System.Drawing.Point(0, 235);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(325, 845);
            this.panel6.TabIndex = 4;
            // 
            // Validationfinale
            // 
            this.Validationfinale.BackColor = System.Drawing.Color.Green;
            this.Validationfinale.FlatAppearance.BorderSize = 0;
            this.Validationfinale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Validationfinale.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Validationfinale.Location = new System.Drawing.Point(0, 748);
            this.Validationfinale.Name = "Validationfinale";
            this.Validationfinale.Size = new System.Drawing.Size(325, 97);
            this.Validationfinale.TabIndex = 8;
            this.Validationfinale.Text = "Valider";
            this.Validationfinale.UseVisualStyleBackColor = false;
            this.Validationfinale.Click += new System.EventHandler(this.Validationfinale_Click);
            // 
            // titrepanier
            // 
            this.titrepanier.AutoSize = true;
            this.titrepanier.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titrepanier.ForeColor = System.Drawing.Color.Black;
            this.titrepanier.Location = new System.Drawing.Point(90, 63);
            this.titrepanier.Name = "titrepanier";
            this.titrepanier.Size = new System.Drawing.Size(132, 54);
            this.titrepanier.TabIndex = 5;
            this.titrepanier.Text = "Panier";
            // 
            // nomcinema
            // 
            this.nomcinema.AutoSize = true;
            this.nomcinema.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomcinema.ForeColor = System.Drawing.Color.White;
            this.nomcinema.Location = new System.Drawing.Point(87, 98);
            this.nomcinema.Name = "nomcinema";
            this.nomcinema.Size = new System.Drawing.Size(156, 54);
            this.nomcinema.TabIndex = 4;
            this.nomcinema.Text = "Cinéma";
            // 
            // buttonconfiserie
            // 
            this.buttonconfiserie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonconfiserie.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonconfiserie.ForeColor = System.Drawing.Color.White;
            this.buttonconfiserie.Location = new System.Drawing.Point(0, 152);
            this.buttonconfiserie.Margin = new System.Windows.Forms.Padding(0);
            this.buttonconfiserie.Name = "buttonconfiserie";
            this.buttonconfiserie.Size = new System.Drawing.Size(325, 122);
            this.buttonconfiserie.TabIndex = 6;
            this.buttonconfiserie.Text = "Confiserie";
            this.buttonconfiserie.UseVisualStyleBackColor = true;
            this.buttonconfiserie.Click += new System.EventHandler(this.buttonconfiserie_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.buttonconfiserie);
            this.panel2.Controls.Add(this.nomcinema);
            this.panel2.Controls.Add(this.logocinema);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 1443);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(46)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.state1);
            this.panel1.Controls.Add(this.state4);
            this.panel1.Controls.Add(this.state3);
            this.panel1.Controls.Add(this.state2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1692, 152);
            this.panel1.TabIndex = 1;
            // 
            // state1
            // 
            this.state1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state1.FlatAppearance.BorderSize = 0;
            this.state1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state1.Location = new System.Drawing.Point(274, 66);
            this.state1.Name = "state1";
            this.state1.Size = new System.Drawing.Size(70, 65);
            this.state1.TabIndex = 13;
            this.state1.UseVisualStyleBackColor = false;
            // 
            // state4
            // 
            this.state4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state4.FlatAppearance.BorderSize = 0;
            this.state4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state4.Location = new System.Drawing.Point(780, 64);
            this.state4.Name = "state4";
            this.state4.Size = new System.Drawing.Size(70, 65);
            this.state4.TabIndex = 12;
            this.state4.UseVisualStyleBackColor = false;
            // 
            // state3
            // 
            this.state3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state3.FlatAppearance.BorderSize = 0;
            this.state3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state3.Location = new System.Drawing.Point(612, 65);
            this.state3.Name = "state3";
            this.state3.Size = new System.Drawing.Size(70, 65);
            this.state3.TabIndex = 11;
            this.state3.UseVisualStyleBackColor = false;
            // 
            // state2
            // 
            this.state2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state2.FlatAppearance.BorderSize = 0;
            this.state2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.state2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state2.Location = new System.Drawing.Point(440, 66);
            this.state2.Name = "state2";
            this.state2.Size = new System.Drawing.Size(70, 65);
            this.state2.TabIndex = 3;
            this.state2.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel4.Location = new System.Drawing.Point(334, 94);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 10);
            this.panel4.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel7.Location = new System.Drawing.Point(676, 94);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(110, 10);
            this.panel7.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(73)))), ((int)(((byte)(89)))));
            this.panel5.Location = new System.Drawing.Point(504, 94);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(114, 10);
            this.panel5.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(716, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 50);
            this.label4.TabIndex = 10;
            this.label4.Text = "Type de place";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(589, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 50);
            this.label3.TabIndex = 9;
            this.label3.Text = "Place";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(405, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(256, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 50);
            this.label1.TabIndex = 7;
            this.label1.Text = "Film";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1582, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 73);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.MainPage_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.logocinema)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public PictureBox logocinema;
        public Panel panel6;
        public Label titrepanier;
        public Label nomcinema;
        public Button buttonconfiserie;
        public Panel panel2;
        public Panel panel1;
        private PictureBox pictureBox3;
        private Button Validationfinale;
        private Panel panel7;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private confiserie.RoundedButton state1;
        private confiserie.RoundedButton state4;
        private confiserie.RoundedButton state3;
        private confiserie.RoundedButton state2;
    }
}