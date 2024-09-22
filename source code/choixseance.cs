using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Usercontrol qui permet d'afficher toutes les séances en fonction du film choisi
namespace ProjetBorneCinema
{
    public partial class choixseance : UserControl
    {
        int nbseance;
        int nbseance_temp;
        int g,k,l,m;

        public film filmchoisi;
        public seance seancechoisie;

        List<seance>[] tableaudeliste;

        private void buttonprecedent_Click(object sender, EventArgs e) //click sur le bouton retour
        {
            MainPage parentControl = this.Parent as MainPage;
            parentControl.ChoixEtatMachine("fermeturechoixseance");
            parentControl.ChoixEtatMachine("choixfilm");
        }

        //La taille de la liste est trouvable dans :
        public choixseance()
        {
            InitializeComponent();

        }

        public void Afficheseance() //fonction qui permet d'afficher toutes les séances en meme temps en fonction du film et met en premier première colone le jour actuel
        { //on décale le tableau des jour en fonction du jour actuel
            tableaudeliste = filmchoisi.tableaudeliste;

            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            string jouractuel = DateTime.Today.ToString("dddd", CultureInfo.CurrentCulture); // On obtient le jour de la semaine en français
            string[] daysOfWeek = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            string[] daysfrom2day = new string[7];
            nbseance = 0;
            nbseance_temp =0;
            int u;
            g = 0;
            u = 0;
            for (m = 0; m < 7; m++)
            {
                nbseance_temp = tableaudeliste[m].Count;
                if(nbseance_temp > nbseance ) 
                { 
                    nbseance= nbseance_temp;
                }

                if (daysOfWeek[m] == jouractuel)
                {
                    u = m;
                    for (l =0; l <7; l++)
                    {
                        g = (l + u) % 7;
                        daysfrom2day[l] = daysOfWeek[g];
                    }
                }
            }
            nbseance = nbseance + 1;

            int i;
            int j;
            int espacecote = 100;
            int espacehaut = 100;
            int espacehaut_temp = espacehaut;
            int espacebas = 50;
            int largeurcase = (1595 - (2*espacecote))/7;
            int hauteurcasemax = largeurcase;
            int hauteurcase = (931 - (espacehaut + espacebas)) / nbseance ;
            if (hauteurcase > hauteurcasemax)
            {
                hauteurcase = hauteurcasemax;
            }

            for (i = 0; i <7; i++) 
            {
                g = (u + i)%7;
                nbseance = tableaudeliste[g].Count + 1;

                for (j=0; j <nbseance; j++) 
                {
                    k = j - 1;
                    Button casejour = new Button();
                    this.Controls.Add(casejour);
                    casejour.Location = new System.Drawing.Point(espacecote, espacehaut_temp);
                    espacehaut_temp = espacehaut_temp + hauteurcase -1;
                    casejour.Width = largeurcase;
                    casejour.Height = hauteurcase;
                    casejour.Margin = new System.Windows.Forms.Padding(0,0,0,0);
                    casejour.FlatStyle = FlatStyle.Flat;
                    casejour.FlatAppearance.BorderSize = 1;
                    casejour.Font = new Font("Segoe UI", 22);
                    if (j==0) 
                    {
                        
                        if (i == 0)
                        {
                            casejour.Paint += new PaintEventHandler(myButton_Paint_gauche);
                        }
                        if (i == 6)
                        {

                        }
                        casejour.Text = daysfrom2day[i];
                        casejour.FlatAppearance.BorderSize = 0;
                        casejour.BackColor = ColorTranslator.FromHtml("#5B9BD5");
                        casejour.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#5B9BD5");
                        casejour.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#5B9BD5"); 
                    }
                    else 
                    {
                        casejour.BackColor = ColorTranslator.FromHtml("#b4c6e7"); 
                        casejour.Name = tableaudeliste[g][k].Name;
                        casejour.Text = tableaudeliste[g][k].horaire;
                        casejour.Click += new EventHandler(casejour_Click);
                    }

                }
                espacecote = espacecote + largeurcase -1;
                espacehaut_temp = espacehaut;
            }
        }
        private void myButton_Paint_gauche(object sender, PaintEventArgs e) //fonction pour créer un bouton rectangle arrondi
        {
            Button button = (Button)sender;
            Rectangle rectangle = new Rectangle(0, 0, button.Width, button.Height);

            GraphicsPath path = CreateRoundRect_gauche(rectangle, 100);

            button.Region = new Region(path);
        }

        private GraphicsPath CreateRoundRect_gauche(Rectangle rectangle, int cornerRadius) //fonction pour mettre l'angle au gauche en arrondi
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(rectangle.X, rectangle.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddLine(rectangle.X + cornerRadius, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y);
            path.AddLine(rectangle.X + rectangle.Width, rectangle.Y, rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            path.AddLine(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height, rectangle.X, rectangle.Y + rectangle.Height);
            path.AddLine(rectangle.X, rectangle.Y + rectangle.Height, rectangle.X, rectangle.Y + cornerRadius * 2);
            path.CloseFigure();

            return path;
        }

        private void casejour_Click(object sender, EventArgs e) // fonction pour détecter sur quel séance on clic
        {
            Button n_casejour = (Button)sender;
            string[] mots = n_casejour.Name.Split('/');
            string jour = mots[0];
            string horaire = mots[1]; //mercredi/12h30/2/A  le A est dans la 3eme partie
            string[] daysOfWeek = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            int rangjour = Array.IndexOf(daysOfWeek, jour);
            int i = 0;
            while (this.tableaudeliste[rangjour][i].Name != n_casejour.Name)
            { i++; }
            seancechoisie = this.tableaudeliste[rangjour][i];

            //On la mets dans temp

            MainPage parentControl = this.Parent as MainPage;

            parentControl.SeanceChoisie = seancechoisie;  //RECUPERER L'OBJET SEANCE QUI A ETE CLIQUE
            parentControl.ChoixEtatMachine("fermeturechoixseance");
            parentControl.ChoixEtatMachine("choixplace");
        }
    }
}
