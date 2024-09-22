using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using static ProjetBorneCinema.panier;

namespace ProjetBorneCinema
{
    public partial class MainPage : Form
    {
        public int nbrplace;

        pagefilm pagechoixfilm;//déclaration des différents user control utilisés
        choixseance pagechoixseance;
        AdminPage pageadministrateur;
        confiserie sucreri;

        public panier lepanier;

        prix pageprix;

        public film FilmChoisi;
        public seance SeanceChoisie;

        int avanceefilm;

        PictureBox imageattente = new PictureBox();

        public MainPage()
        {
            InitializeComponent();
            stockageinit.Lecturefichiersconfig();//on lit les fichiers de configuration (voir stockage init)
            Initpanier();//on affiche la panier à l'écran
            pageadministrateur = new AdminPage();
            this.Controls.Add(pageadministrateur);
            pageadministrateur.Hide();
            //affiche_panier();
            //logocinema.Image = Properties.Resources.logocinema;
            logocinema.Image = stockageinit.logoducinema;//on définit le logo en haut à gauche
            nomcinema.Text = stockageinit.nomcinema;//même chose pour le nom du cinéma
            nomcinema.Location = new Point((panel2.Width - nomcinema.Width) / 2, nomcinema.Location.Y);//on centre le nom
            lepanier.Show();

            PDF_place.DeleteAllPDFFiles(Environment.CurrentDirectory);//Detruit tous les Pdfs existants au démarrage de la borne


            imageattente.Width = 1536;
            imageattente.Height = 864;
            imageattente.Location = new Point(192, 100);
            this.Controls.Add(imageattente);

        }




        /* public void affiche_panier()
         {
             int espace_titre = 75;
             int espace_prix_total = 100;
             panel6.Controls.Add(lepanier);
             lepanier.BackColor = Color.Transparent;
             lepanier.Location = new System.Drawing.Point(0, espace_titre);
             lepanier.Height = panel6.Height -espace_titre - espace_prix_total;
             lepanier.Width = panel6.Width;
         }*/

        private void progession()//gère la barre de progression en haut
        {
            switch (avanceefilm)
            {
                case 1: Extinctionprogression(); state1.BackColor= SystemColors.Window;  break;
                case 2: Extinctionprogression(); state2.BackColor= SystemColors.Window;  break;
                case 3 : Extinctionprogression(); state3.BackColor= SystemColors.Window;  break;
                case 4: Extinctionprogression(); state4.BackColor= SystemColors.Window;  break;
                default:  Extinctionprogression(); break;
            }
        }
       private void Extinctionprogression()//éteint tous les boutons de progression en haut
        {
            state1.BackColor = ColorTranslator.FromHtml("#024959");
            state2.BackColor = ColorTranslator.FromHtml("#024959");
            state3.BackColor = ColorTranslator.FromHtml("#024959");
            state4.BackColor = ColorTranslator.FromHtml("#024959");
        }

        public void ChoixEtatMachine(string etape) //gestion de la machine d'état puisque notre application se comporte comme une machine d'état
        {
            switch (etape)
            {
                case "initborne":
                    Initborne();
                    break;
                case "choixfilm":
                    avanceefilm = 1;
                    progession();
                    Pagechoixfilm();
                    break;
                case "choixseance":
                    avanceefilm = 2;
                    progession();
                    Pagechoixseance();
                    break;
                case "choixplace":
                    avanceefilm = 3;
                    progession();
                    Pagechoixplace();
                    break;
                case "fermeturechoixfilm":
                    Fermeturechoixfilm();
                    break;
                case "fermeturechoixseance":
                    Fermeturechoixseance();
                    break;
                case "fermeturechoixplace":
                    Fermeturechoixplace();
                    break;
                case "choixprix":
                    avanceefilm = 4;
                    progession();
                    Choixprix();
                    break;
                case "fermeturechoixprix":
                    Fermeturechoixprix();
                    break;
                case "pageadmin":
                    PageAdmin();
                    break;
                case "fermeturepageadmin":
                    FermeturePageAdmin();
                    break;
                case "pageconfiserie":
                    avanceefilm = 0;
                    progession();
                    Pageconfiserie();

                    break;
                case "fermeturepageconfiserie":
                    Fermeturepageconfiserie();
                    break;
                default:
                    Pagechoixfilm();
                    break;
            }
        }


        //ci-dessous on décrit ce qui se passe à chaque étape de la machine d'état
        void Initborne() 
        {//prépare ce qu'on doit afficher sur la borne
            sucreri = new confiserie();
            this.Controls.Add(sucreri);
            sucreri.Hide();
            pagechoixfilm = new pagefilm();
            this.Controls.Add(pagechoixfilm);
            pagechoixfilm.Show();

            ChoixEtatMachine("choixfilm");
        }
        void Pagechoixfilm()
        {
            pagechoixfilm.Location = new System.Drawing.Point(panel2.Width, panel1.Height);
            pagechoixfilm.Show();
            pagechoixfilm.retourneurfilm();
        }
        void Pagechoixseance()
        {
            pagechoixseance = new choixseance();
            pagechoixseance.filmchoisi = FilmChoisi;
            pagechoixseance.Afficheseance();
            pagechoixseance.Location = new System.Drawing.Point(panel2.Width, panel1.Height);
            this.Controls.Add(pagechoixseance);
        }
        void Pagechoixplace()
        {
            stockagetemp.nomfilmchoisi = FilmChoisi.nom_film;
            //stockagetemp.tempseancechosie = SeanceChoisie;
            SeanceChoisie.GenerateurSalle();
            SeanceChoisie.Location = new System.Drawing.Point(panel2.Width, panel1.Height);
            this.Controls.Add(SeanceChoisie);
        }
        void Fermeturechoixfilm()
        {
            pagechoixfilm.Hide();
        }
        void Fermeturechoixseance()
        {
            this.Controls.Remove(pagechoixseance);
        }
        void Fermeturechoixplace()
        {
            this.Controls.Remove(SeanceChoisie);
            SeanceChoisie.VideurSalle();

        }

        void Choixprix()
        {
            pageprix = new prix(nbrplace);
            pageprix.Location = new System.Drawing.Point(panel2.Width, panel1.Height);
            this.Controls.Add(pageprix);
        }

        void Fermeturechoixprix()
        {
            this.Controls.Remove(pageprix);
        }

        void PageAdmin()
        {
            pageadministrateur.Show();
            pageadministrateur.Location=new Point(this.Width/2 - pageadministrateur.Width/2 , this.Height / 2 - pageadministrateur.Height / 2);
            pageadministrateur.entermdp.Text = "";
        }
        void FermeturePageAdmin()
        {
            pageadministrateur.Hide();

        }

        void Pageconfiserie()
        {
            sucreri.Show();
            sucreri.Location = new System.Drawing.Point(panel2.Width, panel1.Height);
        }
        void Fermeturepageconfiserie()
        {
            sucreri.Hide();
        }




        private void buttonconfiserie_Click(object sender, EventArgs e)
        {
            if (sucreri.Visible == false)
            {
                switch (avanceefilm)
                {
                    case 1:
                        Fermeturechoixfilm();
                        break;
                    case 2:
                        Fermeturechoixseance();
                        break;
                    case 3:
                        Fermeturechoixplace();
                        SeanceChoisie.Annulation();
                        break;
                    case 4:
                        Fermeturechoixprix();
                        SeanceChoisie.Annulation();
                        break;
                    default:
                        Pagechoixfilm();
                        break;
                }
                ChoixEtatMachine("pageconfiserie");
                buttonconfiserie.Text = "Choix Film";
                

            }
            else
            {
                ChoixEtatMachine("fermeturepageconfiserie");
                ChoixEtatMachine("choixfilm");
                buttonconfiserie.Text = "Confiserie";
            }
  


        }

        public void retourchoixfilm()
        {
            switch (avanceefilm)
            {
                case 0:
                    Fermeturepageconfiserie();
                    break;
                case 2:
                    Fermeturechoixseance();
                    break;
                case 3:
                    Fermeturechoixplace();
                    SeanceChoisie.Annulation();
                    break;
                case 4:
                    Fermeturechoixprix();
                    SeanceChoisie.Annulation();
                    break;
                default:
                    Pagechoixfilm();
                    break;
            }
            ChoixEtatMachine("choixfilm");
            buttonconfiserie.Text = "Choix Film";
        }

     

        private void pictureBox3_Click(object sender, EventArgs e)//c'est l'engrenage permettat d'accéder à la page administrateur
        {
            if(pageadministrateur.Visible == false) 
                 ChoixEtatMachine("pageadmin");
            else
                ChoixEtatMachine("fermeturepageadmin");
        }

        Choix_mail choisistonmail = new Choix_mail();
        private void Validationfinale_Click(object sender, EventArgs e)//quand on clique sur valider
        {
            if(lepanier.prix_total != 0) //si le panier n'est pas vide
            {
                this.Controls.Add(choisistonmail);
                choisistonmail.BringToFront();
            }
        }

        public void apresvalid() //une fois que les pdf ont été génerés on propose de choisir entre envoi par mail et impression
        {
            string mail = Choix_mail.adressemail;
            bool etat_print = Choix_mail.boolprint;
            bool etat_mail = Choix_mail.boolmail;
            lepanier.impressionpanier(etat_mail, etat_print, mail);
            this.Controls.Remove(choisistonmail);
            /*
            Thread.Sleep(100);
            imageattente.Image = Properties.Resources.bonneseance;
            imageattente.Visible = true;
            imageattente.BringToFront();
            Thread.Sleep(2000);*/
            imageattente.Visible = false;
        }






        void Initpanier()
        {
            lepanier = new panier();
            this.Controls.Add(lepanier);
            lepanier.Height = this.Height - titrepanier.Location.Y - titrepanier.Height - Validationfinale.Height - panel1.Height - buttonconfiserie.Height + 30;
            lepanier.Location = new Point(0, titrepanier.Location.Y + titrepanier.Height + panel1.Height + buttonconfiserie.Height - 30);
            lepanier.Width = panel6.Width;
            lepanier.BringToFront();
            lepanier.buttonprix.Location = new Point(0, lepanier.Height - lepanier.buttonprix.Height);
            lepanier.buttonprix.Width = panel6.Width;
            lepanier.buttonprix.FlatStyle = FlatStyle.Flat;
            lepanier.buttonprix.FlatAppearance.BorderSize = 0;
            lepanier.buttonprix.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }

        public async void affichagetransition()
        {
            //Dire ce qu'on veut faire pendant la transition entre 2 clients
            //On a choisi de ne pas afficher d'écran "merci de votre commande"
            buttonconfiserie.Text = "Confiserie";
            retourchoixfilm();
        }

        public void extinctionfinale()//fermeture de l'application
        {
            DialogResult retour = MessageBox.Show("Voulez-vous fermer l'application ?", "Fermeture de la fenetre", MessageBoxButtons.YesNo);
            if (retour == DialogResult.Yes) { Close(); }
        }

        private void MainPage_Shown(object sender, EventArgs e)
        {//Au démarrage de l'application :
            imageattente.BringToFront();//On mets l'image d'attente pour prévenir que ça va être long
            imageattente.Visible = true;
            imageattente.Image = Properties.Resources.photoimageattente;

            //Le temps de démarrage très long est dù à l'instruction ci-dessous :
            stockageinit.recuperateurfilms();//On fait la récupération de tous les films qui va prendre de 5 à 30 secondes selon nos observations
            ChoixEtatMachine("initborne");//On débute la machine d'état
            imageattente.Visible = false;//On elève l'cran d'attente
        }
    }
}