using PdfSharp.Pdf.Content.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetBorneCinema
{
    //cette classe définit le panneau administrateur
    //le mot de passe est jesuisadmin (la sécurité n'était pas vraiment une priorité pour le choix de ce mot de passe)
    public partial class AdminPage : UserControl
    {

        string jourchoisi;
        string mdp = "jesuisadmin";
        PictureBox imagecache;

        public AdminPage()
        {
            InitializeComponent();
            imagecache= new PictureBox();
            imagecache.BackColor= Color.Black;
            imagecache.Location = new Point(0, 50);
            imagecache.Height = this.Height - 50;
            imagecache.Width = this.Width;
            this.Controls.Add(imagecache);
            imagecache.Show();
            imagecache.BringToFront();


            choixjour.Items.Add("lundi");//on définit les élements de la liste déroulante
            choixjour.Items.Add("mardi");
            choixjour.Items.Add("mercredi");
            choixjour.Items.Add("jeudi");
            choixjour.Items.Add("vendredi");
            choixjour.Items.Add("samedi");
            choixjour.Items.Add("dimanche");

            // Sélectionner le premier élément de la liste déroulante par défaut
            choixjour.SelectedIndex = 0;

            entermdp.UseSystemPasswordChar = true;//pour afficher ****** lorsqu'on entre le mot de passe

        }

        private void buttonactualisateur_Click(object sender, EventArgs e)
        {
            ActualiseurSalle();
        }


        public void ActualiseurSalle() //détruit tout et refait tout dans la base de donnée
        {
            DestructeurDataBaseSalle(stockageinit.StockageDictionnairetaillesalle);
            GenerateurDataBaseSalle(stockageinit.StockageDictionnairetaillesalle);
        }


        public void GenerateurDataBaseSalle(IDictionary<int, Point> taillesalles)
        {
            //on crée toutes les salles pour tous les jours et pour les 6 créneaux (choix personnel pour ne pas trop charger la base de donnée)
            //e à chaque fois on crée un tableau de booléens de la taille de la salle
            //Le numéro de la salle est le int dans le dictionnaire, ensuite pour chaque salle on fait une boucle pour les 7 jours
            //et une boucle pour les 6 séances de la journée

            int numsalle;
            string jour;
            string creneau;
            string titre;

            int nbrcreneaux = 6;

            int i,j, k;
            string[] daysOfWeek = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            for (i=1; i<taillesalles.Count + 1; i++)//Les numéros des salles sont compris entre 1 et beaucoup
            {
                numsalle = i;

                for(j = 0; j<7; j++)
                {
                    jour = daysOfWeek[j];
                    for(k = 0; k<nbrcreneaux;k++)
                    {
                        creneau = ((char)('A' + k)).ToString();

                        titre = "Salle" + numsalle.ToString() + "/" +jour + "/" + creneau;
                        Database.CreateurTableaux(titre, taillesalles[numsalle].Y, taillesalles[numsalle].X);
                        /*On a remqrqué que le tableau se créait souvent mal donc on force jusqu'à ce que ça marche*/
                        while (!(Database.Verificateurexistence(titre + "/0/0")))//On vérifie si le tableau a bien été créé en vérifiant si la première case n'est pas nulle
                        {
                            Database.CreateurTableaux(titre, taillesalles[numsalle].Y, taillesalles[numsalle].X).GetAwaiter();
                        }
                    }
                }
            }
        }





        public void DestructeurDataBaseSalle(IDictionary<int, Point> taillesalles)//detruit tout les tableaux
        {
            //Le numéro de la salle est le int dans le dictionnaire, ensuite pour chaque salle on fait une boucle pour les 7 jours
            //et une boucle pour les 6 séances de la journée

            int numsalle;
            string jour;
            string creneau;
            string titre;

            int nbrcreneaux = 6;

            int i, j, k;
            string[] daysOfWeek = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };
            for (i = 1; i < taillesalles.Count + 1; i++)//Les numéros des salles sont compris entre 1 et beaucoup
            {
                numsalle = i;

                for (j = 0; j < 7; j++)
                {
                    jour = daysOfWeek[j];
                    for (k = 0; k < nbrcreneaux; k++)
                    {
                        creneau = ((char)('A' + k)).ToString();
                        titre = "Salle" + numsalle.ToString() + "/" + jour + "/" + creneau;
                        Database.DestructeurTableaux(titre);
                    }
                }
            }
        }
        public void ActualiseurJourSalle(IDictionary<int, Point> taillesalles)
            //supprime et recrée le tableau de booléens pour le jour sélectionné dans le menu déroulant et stocké dans this.jourchoisi

        {
            //Le numéro de la salle est le int dans le dictionnaire, ensuite pour chaque salle on fait une boucle pour les 7 jours
            //et une boucle pour les 6 séances de la journée

            int numsalle;
            string jour;
            string creneau;
            string titre;

            int nbrcreneaux = 6;

            int i, j, k;
            for (i = 1; i < taillesalles.Count + 1; i++)//Les numéros des salles sont compris entre 1 et beaucoup
            {
                numsalle = i;
                titre = "Salle" + numsalle.ToString() + "/" + jourchoisi;
                Database.DestructeurTableaux(titre).GetAwaiter();//On detruit puis on crée

                for (k = 0; k < nbrcreneaux; k++)
                {
                    creneau = ((char)('A' + k)).ToString();
                    titre = "Salle" + numsalle.ToString() + "/" + jourchoisi + "/" + creneau;
                    Database.CreateurTableaux(titre, taillesalles[numsalle].Y, taillesalles[numsalle].X).GetAwaiter();

                    while( !(Database.Verificateurexistence(titre + "/0/0")))//On vérifie si le tableau a bien été créé en vérifiant si la première case n'est pas nulle
                    {
                        Database.CreateurTableaux(titre, taillesalles[numsalle].Y, taillesalles[numsalle].X).GetAwaiter();
                    }
                }
            }
        }

        private void choixjour_SelectedIndexChanged(object sender, EventArgs e)//définit jourchoisi en fonction du menu déroulant
        {
            jourchoisi = choixjour.SelectedItem.ToString();
            
        }

        private void validjour_Click(object sender, EventArgs e) //active l'actualisation du jour choisi
        {
            ActualiseurJourSalle(stockageinit.StockageDictionnairetaillesalle);
        }

        private void entermdp_TextChanged(object sender, EventArgs e)//quand une lettre change dans la textbox du mo de passe on regarde si le mot de passe
            //est le bon
        {
            if (entermdp.Text == mdp) //si le mdp est correct on enlève la picture box qui cache
            {
                imagecache.Visible = false;
            }
            else
            {
                imagecache.Visible = true;
                imagecache.BringToFront();
            }
        }

        private void ButtonFermeture_Click(object sender, EventArgs e)
        {
            MainPage parentControl = this.Parent as MainPage;
            parentControl.extinctionfinale(); //va éteindre l'application après une message box de confirmation
        }
    }
}