using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 Cette classe est le usercontrole qui permet de choisir si on veut envoyer des mails ou impimer le panier
 */

namespace ProjetBorneCinema
{
    public partial class Choix_mail : UserControl
    {
        string patern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"; 
        //patern pour garentir une adresse mail valable
        ErrorProvider errorProvider1 = new ErrorProvider(); //Indication a droite de la textebox qui indique que le mail n'est pas valide
        private string defaultText = "Entrez votre adresse mail";
        public bool mailvalide;
        public bool mailcorrect;

        public static string adressemail;
        public static bool boolmail;
        public static bool boolprint;
        public Choix_mail() //permet de choisir le mail
        {
            InitializeComponent();
            initform();
        }

        public void initform() //initialise le usercontrol avec les checkbox et le buoton valider
        {
            Font policetexte = new Font("Segoe UI Symbol", 16);
            label1.Font = policetexte;
            textBox1.Font = policetexte;
            checkBoximpr.Font = policetexte;
            checkBoxmail.Font = policetexte;
            textBox1.Visible = false;
            textBox1.Text = defaultText;
            buttonvalider.BackColor = Color.Red;
            prix.CreateRoundButton(buttonvalider);
            buttonvalider.FlatStyle = FlatStyle.Flat;
            buttonvalider.FlatAppearance.BorderSize = 0;
            label1.Text = "Veuillez choisir si vous voulez envoyer vos places par mail \nou les imprimer. Vous devez au moins en choisir.";
            int x = (this.Width - label1.Width) / 2;
            int y = label1.Location.Y;
            label1.Location = new Point(x, y);
            this.Location = new Point(350 + 797 - (this.Width / 2), 150 + 465 - (this.Height / 2));
            y = buttonvalider.Location.Y;
            buttonvalider.Location = new Point(this.Width / 2 - buttonvalider.Width / 2, y);
            checkBoxmail.Height = checkBoximpr.Height;
            textBox1.Height = checkBoximpr.Height;
        }
        private void changecouleur() //fonction pour changer la couleur et le texte du bouton valider quand les critères sont réuni
        {
            if (mailvalide == true)
            {
                buttonvalider.Text = "Valider";
                buttonvalider.BackColor = Color.Green;
            }
            else
            {
                buttonvalider.BackColor = Color.Red;
            }
        }
        //détection des clics, quand on change du texte et entre dans la textebox
        private void textBox1_click(object sender, EventArgs e) // qaund on click dessus met du vide pour rentrer notre mail
        {
            if (textBox1.Text == defaultText)
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_Enter(object sender, EventArgs e) //pareil quand on rentre dedans
        {
            if (textBox1.Text == defaultText)
            {
                textBox1.Text = "";
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e) // permet de détecter quand le mail est valide
        {
            if (Regex.IsMatch(textBox1.Text, patern) == false)
            {
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Adresse e-mail invalide");
                mailcorrect = false;
            }
            else
            {
                errorProvider1.Clear();
                mailcorrect = true;
            }
            checkboxvalide();
            changecouleur();
        }
        private void textBox1_Leave(object sender, EventArgs e) 
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = defaultText;
            }
        }

        public void checkboxvalide() //détecte si les checkbox sont valide et si les conditions sont réunies
        {
            if ((checkBoximpr.Checked && checkBoxmail.Checked == false) || (checkBoximpr.Checked && checkBoxmail.Checked == false && mailcorrect == true) || ((checkBoxmail.Checked) && (mailcorrect == true)))
            {
                mailvalide = true;
            }
            else
            {
                mailvalide = false;
            }

        }
        private void checkBoxmail_CheckedChanged(object sender, EventArgs e) //détecte si l'état de la checkbox mail change
        {
            if (checkBoxmail.Checked == true)
            {
                textBox1.Visible = true;
                boolmail = true;

            }
            else
            {
                textBox1.Visible = false;
                boolmail = false;
            }
            checkboxvalide();
            changecouleur();
        }
        private void checkBoximpr_CheckedChanged(object sender, EventArgs e) // détecte si l'état de la checkbox imprimer change
        {
            if (checkBoximpr.Checked == true)
            {
                boolprint = true;
            }
            if (checkBoximpr.Checked == false)
            {
                boolprint = false;
            }
            checkboxvalide();
            changecouleur();
        }

        private void buttonvalider_Click(object sender, EventArgs e)//bouton pour valider
        {
            if (mailvalide == true)
            {
                adressemail = textBox1.Text;
                MainPage parentControl = this.Parent as MainPage;
                parentControl.apresvalid();
                textBox1.Text = defaultText;
            }
        }
    }
}
