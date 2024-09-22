using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

using TMDbLib.Client;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using Firebase.Database.Http;
using TMDbLib.Objects.Languages;
using System.Drawing.Drawing2D;
using System.Security.Policy;

//usercontrole avec la déclaration dela classe film qui va chercher 

namespace ProjetBorneCinema
{
    public partial class film : UserControl
    {

        string adresse_sheet_init = stockageinit.adresse_sheet;
        string nom_sheet_programme = "Programme";

        PictureBox ImageAffiche = new PictureBox();

        public List<seance>[] tableaudeliste = new List<seance>[7];

        public string nom_film = "Astérix et obélix";
        string note = "4";
        string duree = "1h24";
        string genre = "Aventure, Comédie";
        string acteurs = "Gérard De Pardieux";
        string realisateur = "Guillaume Canet";
        string addresseimage;

        int presanceimage = 1;

        public film()
        {
            InitializeComponent();

            foreach (Control control in this.Controls) //détection de clic sur n'importe quoi dans la classe film
            {
                if (control is TextBox)
                {
                    control.Click += new EventHandler(textBox_Click);
                }
            }

        }
        public class RoundPictureBox : PictureBox // classe pour créer une picturebox ronde
        {
            protected override void OnPaint(PaintEventArgs pe)
            {
                base.OnPaint(pe);

                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(this.ClientRectangle);

                    this.Region = new Region(path);
                }
            }
        }
        public void allerchoixseance()
        {
            //ici mettre ce qui ce passe quand on click sur image ou textebox
        }
        public void InitFilm(int numfilm)//On crée toutes les séances pour chaque film
        {


            //Déclaration des listes
            for (int k = 0; k < 7; k++)
            {
                tableaudeliste[k] = new List<seance>();
            }
            IList<IList<string>> programme;//C'est en dessous qu'on définit qu'on saute de 9 et qu'on ajoute 1 // 1 1 8 9

            programme = GoogleSheets.GetCellValueRange(adresse_sheet_init, nom_sheet_programme, numfilm * 9 + 1, 1, numfilm * 9 + 9, 8);//Attention la ligne de fin doit être 9
            //On a maintenant un tableau de 9 lignes et 8 colonnes avec en haut à gauche le nom du film
            //En dessous on a en abcisse les jours de la semaine et en dessous horaire_seance/num_salle
            string horaire;
            int numsalle;
            char ranghoraire;
            string[] daysOfWeek = { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            int i, j;
            string numsalle_txt;


            this.Name = programme[0][0];
            this.nom_film = programme[0][0];

            for (i = 1; i < 8; i++) //On se balade dans les colonnes 2 à 8
            {
                for (j = 1; j < 9; j++)//On descend
                {
                    if (programme[j][i] != "vide")//C'est bien d'abord j. En effet on se balade en descendant dans chaque colonne donc pas de la manière habituelle
                    {//Si il y a quelque chose de marqué dans la case
                        string textecellule = programme[j][i];
                        //On extrait l'horaire et le num de la salle

                        int compt_txtcell = 0;//On commence à 0
                        horaire = "";//Il commence vide
                        while (textecellule[compt_txtcell] != '/')
                        {
                            horaire = horaire + textecellule[compt_txtcell].ToString();
                            compt_txtcell++;
                        }
                        compt_txtcell++; //On saute le /
                        numsalle_txt = textecellule[compt_txtcell].ToString();
                        compt_txtcell++;
                        while (textecellule[compt_txtcell] != '/')
                        {
                            numsalle_txt = numsalle_txt + textecellule[compt_txtcell].ToString();
                            compt_txtcell++;
                        }
                        ranghoraire = textecellule[compt_txtcell + 1];//Après la fin de l'horaire on saute le / et on récupère ranghoraire
                        numsalle = int.Parse(numsalle_txt);
                        //Fin de l'analyse du contenu de la cellule
                        //On assigne :

                        seance newseance = new seance();
                        newseance.numsalle = numsalle;
                        newseance.horaire = horaire;
                        newseance.ranghoraire = ranghoraire;
                        newseance.jour = daysOfWeek[i - 1]; //le lundi : case 0 du tableau correspond à i = 1
                        newseance.Name = newseance.jour + "/" + newseance.horaire +"/" + newseance.numsalle.ToString() + "/" + newseance.ranghoraire;
                        newseance.adressesalle = "Salle" + newseance.numsalle.ToString() + "/" + newseance.jour + "/" + newseance.ranghoraire;

                        newseance.GetTailleSalle();
                        tableaudeliste[i-1].Add(newseance);

                    }
                }
            }

        }

        public static List<film> Initallfilm() //initialisation des films avec les paramètres adéquats (affiche, nom ...)
        {
            string adresse_sheet_init = stockageinit.adresse_sheet; 
            string nom_sheet_programme = "Programme";
            int numfilm = 0;
            List<film> p_tableaudefilms = new List<film>();
            while (GoogleSheets.GetCellValue(adresse_sheet_init, nom_sheet_programme, numfilm * 9 + 1, 1) != "vide")
            {
                film newfilm = new film();
                newfilm.InitFilm(numfilm);
                newfilm.ApparenceFilm();
                numfilm++;

                p_tableaudefilms.Add(newfilm);
            }
            return p_tableaudefilms;
        }
        
        public void textBox_Click(object sender, EventArgs e) 
        {
            TextBox textBox = (TextBox)sender;
            allerchoixseance();
        }
        public void ApparenceFilm() // déclaration de l'apparance de la classe film pour afficher le titre, les cateurs, l'affiche, etc...
            //C'est dans cette méthode qu'on effectue les requêtes TMDB pour récuperer les données sur les différents films
        {
            TMDbClient client = new TMDbClient("1672cdb990faac174269e58efdda97c4");//clé de l'API TMDB
            client.DefaultLanguage = "fr";//
            client.DefaultCountry = "FR";//Choix du langage pour obtenir les bonnes affiches
            SearchContainer<SearchMovie> results = client.SearchMovieAsync(nom_film).Result;//on récupère l'Id du film avec son nom
            int movieId = results.Results[0].Id;
            Movie movieDetails = client.GetMovieAsync(movieId).Result;  

            string adresseimage = "https://image.tmdb.org/t/p/original" + movieDetails.PosterPath;//recuperation de l'affiche
            Font Police_label = new Font("Franklin Gothic Book", 14);
            ImageAffiche.SizeMode = PictureBoxSizeMode.Zoom;
            ImageAffiche.Load(adresseimage);
            ImageAffiche.Height = 390;
            ImageAffiche.Width = 260; //292 de base
            ImageAffiche.Location = new System.Drawing.Point(0, 0);
            //On ajoute l'event
            ImageAffiche.Click += new EventHandler(clictotal);
            this.Controls.Add(ImageAffiche);
            textBox1.ReadOnly = true; // mettre la textebox en lecture
            textBox1.Text = nom_film;
            int length = nom_film.Length;
            int police;
            if (length < 13)  //On ajuste la taille de la police en fonction de la longueur du titre
            {
                police = 20;
            }
            else
            {
                police = 20 - ((length - 13) / 2); // si le texte est plus grand que 13 lettres, on baisse la taille de 1 tout les deux caractère suplémentaire
                if (police < 15)
                {
                    police = 15;
                    string titrefilm = stockagetemp.CouperChaine(textBox1.Text,20);
                    textBox1.Text = titrefilm;
                }
            }
            textBox1.Font = new Font("Times New Roman", police);


            textBox2.ReadOnly = true;
            textBox2.Text = Math.Round(movieDetails.VoteAverage, 1) + "/10";

            int hours = Convert.ToInt16(movieDetails.Runtime) / 60;
            int minutes = Convert.ToInt16(movieDetails.Runtime) % 60;

            // Afficher la durée au format hh:mm
            string duration = string.Format("{0:00}h{1:00}", hours, minutes);

            label2.Text = "Durée : " + duration;
            label2.Font = Police_label;

            label3.Text = "Genre : " + movieDetails.Genres[0].Name;
            label3.Font = Police_label;

            

            Credits credits = client.GetMovieCreditsAsync(movieId).Result;
            string textereal = "Réalisateur : ";
            if (credits.Crew.FirstOrDefault(c => c.Job == "Director")?.Name != null) {  }
            try { textereal = textereal + credits.Crew.FirstOrDefault(c => c.Job == "Director")?.Name; } catch (System.ArgumentOutOfRangeException) { }


            int maxLength = 22;
            string wrappedText = "";

            while (textereal.Length > maxLength)
            {
                int spaceIndex = textereal.Substring(0, maxLength).LastIndexOf(" ");
                if (spaceIndex == -1) spaceIndex = maxLength;
                wrappedText += textereal.Substring(0, spaceIndex).Trim() + "\n";
                textereal = textereal.Substring(spaceIndex).TrimStart();
            }
            wrappedText += textereal;
            label4.Text = wrappedText;
            label4.Font = Police_label;

            string texteact = "Acteur : ";
            for(int m = 0; m<3; m++) 
            { 
                try 
                { texteact = texteact + credits.Cast[m].Name + ", "; }
                catch (System.ArgumentOutOfRangeException) { }
            }
            wrappedText = "";
            while (texteact.Length > maxLength)
            {
                int spaceIndex = texteact.Substring(0, maxLength).LastIndexOf(" ");
                if (spaceIndex == -1) spaceIndex = maxLength;
                wrappedText += texteact.Substring(0, spaceIndex).Trim() + "\n";
                texteact = texteact.Substring(spaceIndex).TrimStart();
            }
            wrappedText += texteact;
            label5.Text = wrappedText;
            label5.Font = Police_label;

            ImageAffiche.BringToFront();
            pictureBox2.BringToFront();
        }
        private void pictureBox2_Click(object sender, EventArgs e) //Le bouton reverse en bas à gache de chaque affiche
        {
            
            if (presanceimage == 1)
            {
                ImageAffiche.Visible = false;
                presanceimage = 0;
                pictureBox2.BackColor = Color.White;
            }
            else
            {
                ImageAffiche.Visible = true;
                presanceimage = 1;
                pictureBox2.BackColor = Color.Bisque;
            }
        }

        public void coteaffiche() //on verra l'affiche du film à l'écran
        {
            ImageAffiche.Visible = true;
            presanceimage = 1;
        }
        private void clictotal(object sender, EventArgs e)
        {
            // Déclenchement de l'événement Click lorsqu'on clique sur n'importe quel élement composant le film (sauf le bouton reverse) ce 
            //qui signifie qu'on passe à l'étape de choix de la séance
            OnClick(e);
        }


        
    }

}

