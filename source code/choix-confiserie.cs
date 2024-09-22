using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMDbLib.Objects.Account;

//usercontrole avec tous les panels de la confiserie en static

namespace ProjetBorneCinema
{
    public partial class confiserie : UserControl
    {
        //confiserie
        RoundedPanel panel_grand_popcorn_sale = new RoundedPanel();

        RoundedPanel panel_moyen_popcorn_sale = new RoundedPanel();
        RoundedPanel panel_petit_popcorn_sale = new RoundedPanel();
        RoundedPanel panel_bonbon = new RoundedPanel();
        RoundedPanel panel_mms = new RoundedPanel();
        RoundedPanel panel_glace = new RoundedPanel();
        //boisson
        RoundedPanel panel_icetea = new RoundedPanel();
        RoundedPanel panel_coca = new RoundedPanel();
        RoundedPanel panel_sprite = new RoundedPanel();
        RoundedPanel panel_fanta = new RoundedPanel();
        RoundedPanel panel_eau = new RoundedPanel();
        RoundedPanel panel_caprisun = new RoundedPanel();
        //formule
        RoundedPanel panel_grande_for = new RoundedPanel();
        RoundedPanel panel_moyenne_for = new RoundedPanel();
        RoundedPanel panel_petite_for = new RoundedPanel();
        RoundedPanel panel_glace_for = new RoundedPanel();

        //liste avec le nombre



        Font police = new Font("Century Gothic", 15F);
        public confiserie()
        {
            InitializeComponent();
            affiche_choix_confis();
        }

        public void affiche_choix_confis() //création de touts les pannels de la confiseries et ce qu'il y a dedans ainsi que la détection des clicks
        {
            buttonprecedent.Visible = false;
            panel_menu.Click += new EventHandler(panel_menu_click);
            panel_boisson.Click += new EventHandler(panel_boisson_click);
            panel_confiserie.Click += new EventHandler(panel3_confiserie_click);
            //confiserie
            panel_grand_popcorn_sale.Click += new EventHandler(panel_grand_popcorn_sale_Click);
            panel_moyen_popcorn_sale.Click += new EventHandler(panel_moyen_popcorn_sale_Click);
            panel_petit_popcorn_sale.Click += new EventHandler(panel_petit_popcorn_sale_Click);
            panel_bonbon.Click += new EventHandler(panel_bonbon_Click);
            panel_mms.Click += new EventHandler(panel_mms_Click);
            panel_glace.Click += new EventHandler(panel_glace_Click);
            //boisson
            panel_icetea.Click += new EventHandler(panel_icetea_Click);
            panel_coca.Click += new EventHandler(panel_coca_Click);
            panel_sprite.Click += new EventHandler(panel_sprite_Click);
            panel_fanta.Click += new EventHandler(panel_fanta_Click);
            panel_eau.Click += new EventHandler(panel_eau_Click);
            panel_caprisun.Click += new EventHandler(panel_caprisun_Click);
            //menu
            panel_grande_for.Click += new EventHandler(panel_grande_for_Click);
            panel_moyenne_for.Click += new EventHandler(panel_moyenne_for_Click);
            panel_petite_for.Click += new EventHandler(panel_petite_for_Click);
            panel_glace_for.Click += new EventHandler(panel_glace_for_Click);

            //confiserie
            this.Controls.Add(panel_grand_popcorn_sale);

            Label label_grand_popcorn_sale = new Label();
            Label prix_grand_popcorn_sale = new Label();
            PictureBox pictureBox_grand_popcorn_sale = new PictureBox();
            panel_grand_popcorn_sale.Controls.Add(label_grand_popcorn_sale);
            panel_grand_popcorn_sale.Controls.Add(prix_grand_popcorn_sale);
            panel_grand_popcorn_sale.Controls.Add(pictureBox_grand_popcorn_sale);
            pictureBox_grand_popcorn_sale.Image = Properties.Resources.Popcorn_PNG3;
            pictureBox_grand_popcorn_sale.Location = new Point(104, 85);
            pictureBox_grand_popcorn_sale.Height = 215;
            pictureBox_grand_popcorn_sale.Width = 215;
            pictureBox_grand_popcorn_sale.SizeMode = PictureBoxSizeMode.Zoom;
            label_grand_popcorn_sale.AutoSize = true;
            prix_grand_popcorn_sale.AutoSize = true;
            label_grand_popcorn_sale.Font = police;
            prix_grand_popcorn_sale.Font = police;
            label_grand_popcorn_sale.Location = new Point(25, 25);
            prix_grand_popcorn_sale.Location = new Point(25, 334);
            label_grand_popcorn_sale.Text = "(L) Pop Corn Salé";
            prix_grand_popcorn_sale.Text = "Prix : " + stockageinit.prixconfis["Grand_popcorn_sale"] + " €";

            panel_grand_popcorn_sale.Location = new Point(81, 50);
            panel_grand_popcorn_sale.Width = 423;
            panel_grand_popcorn_sale.Height = 390;
            panel_grand_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            panel_grand_popcorn_sale.Hide();

            this.Controls.Add(panel_moyen_popcorn_sale);

            Label label_moyen_popcorn_sale = new Label();
            Label prix_moyen_popcorn_sale = new Label();
            PictureBox pictureBox_moyen_popcorn_sale = new PictureBox();
            panel_moyen_popcorn_sale.Controls.Add(label_moyen_popcorn_sale);
            panel_moyen_popcorn_sale.Controls.Add(prix_moyen_popcorn_sale);
            panel_moyen_popcorn_sale.Controls.Add(pictureBox_moyen_popcorn_sale);
            pictureBox_moyen_popcorn_sale.Image = Properties.Resources.Popcorn_PNG3;
            pictureBox_moyen_popcorn_sale.Location = new Point(104, 85);
            pictureBox_moyen_popcorn_sale.Height = 215;
            pictureBox_moyen_popcorn_sale.Width = 215;
            pictureBox_moyen_popcorn_sale.SizeMode = PictureBoxSizeMode.Zoom;
            label_moyen_popcorn_sale.AutoSize = true;
            prix_moyen_popcorn_sale.AutoSize = true;
            label_moyen_popcorn_sale.Font = police;
            prix_moyen_popcorn_sale.Font = police;
            label_moyen_popcorn_sale.Location = new Point(25, 25);
            prix_moyen_popcorn_sale.Location = new Point(25, 334);
            label_moyen_popcorn_sale.Text = "(M) Pop Corn Salé";
            prix_moyen_popcorn_sale.Text = "Prix : " + stockageinit.prixconfis["Moyen_popcorn_sale"] + " €";

            panel_moyen_popcorn_sale.Location = new Point(585, 50);
            panel_moyen_popcorn_sale.Width = 423;
            panel_moyen_popcorn_sale.Height = 390;
            panel_moyen_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            panel_moyen_popcorn_sale.Hide();

            this.Controls.Add(panel_petit_popcorn_sale);

            Label label_petit_popcorn_sale = new Label();
            Label prix_petit_popcorn_sale = new Label();
            PictureBox pictureBox_petit_popcorn_sale = new PictureBox();
            panel_petit_popcorn_sale.Controls.Add(label_petit_popcorn_sale);
            panel_petit_popcorn_sale.Controls.Add(prix_petit_popcorn_sale);
            panel_petit_popcorn_sale.Controls.Add(pictureBox_petit_popcorn_sale);
            pictureBox_petit_popcorn_sale.Image = Properties.Resources.Popcorn_PNG3;
            pictureBox_petit_popcorn_sale.Location = new Point(104, 85);
            pictureBox_petit_popcorn_sale.Height = 215;
            pictureBox_petit_popcorn_sale.Width = 215;
            pictureBox_petit_popcorn_sale.SizeMode = PictureBoxSizeMode.Zoom;
            label_petit_popcorn_sale.AutoSize = true;
            prix_petit_popcorn_sale.AutoSize = true;
            label_petit_popcorn_sale.Font = police;
            prix_petit_popcorn_sale.Font = police;
            label_petit_popcorn_sale.Location = new Point(25, 25);
            prix_petit_popcorn_sale.Location = new Point(25, 334);
            label_petit_popcorn_sale.Text = "(S) Pop Corn Salé";
            prix_petit_popcorn_sale.Text = "Prix : " + stockageinit.prixconfis["Petit_popcorn_sale"] + " €";

            panel_petit_popcorn_sale.Location = new Point(1089, 50);
            panel_petit_popcorn_sale.Width = 423;
            panel_petit_popcorn_sale.Height = 390;
            panel_petit_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            panel_petit_popcorn_sale.Hide();

            this.Controls.Add(panel_bonbon);

            Label label_bonbon = new Label();
            Label prix_bonbon = new Label();
            PictureBox pictureBox_bonbon = new PictureBox();
            panel_bonbon.Controls.Add(label_bonbon);
            panel_bonbon.Controls.Add(prix_bonbon);
            panel_bonbon.Controls.Add(pictureBox_bonbon);
            pictureBox_bonbon.Image = Properties.Resources.bonbon;
            pictureBox_bonbon.Location = new Point(104, 85);
            pictureBox_bonbon.Height = 215;
            pictureBox_bonbon.Width = 215;
            pictureBox_bonbon.SizeMode = PictureBoxSizeMode.Zoom;
            label_bonbon.AutoSize = true;
            prix_bonbon.AutoSize = true;
            label_bonbon.Font = police;
            prix_bonbon.Font = police;
            label_bonbon.Location = new Point(25, 25);
            prix_bonbon.Location = new Point(25, 334);
            label_bonbon.Text = "BonBon";
            prix_bonbon.Text = "Prix : " + stockageinit.prixconfis["Bonbon"] + " €";

            panel_bonbon.Location = new Point(81, 490);
            panel_bonbon.Width = 423;
            panel_bonbon.Height = 390;
            panel_bonbon.BackColor = Color.FromArgb(227, 230, 237);
            panel_bonbon.Hide();

            this.Controls.Add(panel_mms);

            Label label_mms = new Label();
            Label prix_mms = new Label();
            PictureBox pictureBox_mms = new PictureBox();
            panel_mms.Controls.Add(label_mms);
            panel_mms.Controls.Add(prix_mms);
            panel_mms.Controls.Add(pictureBox_mms);
            pictureBox_mms.Image = Properties.Resources.MMS;
            pictureBox_mms.Location = new Point(104, 85);
            pictureBox_mms.Height = 215;
            pictureBox_mms.Width = 215;
            pictureBox_mms.SizeMode = PictureBoxSizeMode.Zoom;
            label_mms.AutoSize = true;
            prix_mms.AutoSize = true;
            label_mms.Font = police;
            prix_mms.Font = police;
            label_mms.Location = new Point(25, 25);
            prix_mms.Location = new Point(25, 334);
            label_mms.Text = "MM'S";
            prix_mms.Text = "Prix : " + stockageinit.prixconfis["MM's"] + " €";

            panel_mms.Location = new Point(585, 490);
            panel_mms.Width = 423;
            panel_mms.Height = 390;
            panel_mms.BackColor = Color.FromArgb(227, 230, 237);
            panel_mms.Hide();

            this.Controls.Add(panel_glace);

            Label label_glace = new Label();
            Label prix_glace = new Label();
            PictureBox pictureBox_glace = new PictureBox();
            panel_glace.Controls.Add(label_glace);
            panel_glace.Controls.Add(prix_glace);
            panel_glace.Controls.Add(pictureBox_glace);
            pictureBox_glace.Image = Properties.Resources.magnum;
            pictureBox_glace.Location = new Point(104, 85);
            pictureBox_glace.Height = 215;
            pictureBox_glace.Width = 215;
            pictureBox_glace.SizeMode = PictureBoxSizeMode.Zoom;
            label_glace.AutoSize = true;
            prix_glace.AutoSize = true;
            label_glace.Font = police;
            prix_glace.Font = police;
            label_glace.Location = new Point(25, 25);
            prix_glace.Location = new Point(25, 334);
            label_glace.Text = "Glace";
            prix_glace.Text = "Prix : " + stockageinit.prixconfis["Glace"] + " €";

            panel_glace.Location = new Point(1089, 490);
            panel_glace.Width = 423;
            panel_glace.Height = 390;
            panel_glace.BackColor = Color.FromArgb(227, 230, 237);
            panel_glace.Hide();
            //boisson

            this.Controls.Add(panel_icetea);

            Label label_icetea = new Label();
            Label prix_icetea = new Label();
            PictureBox pictureBox_icetea = new PictureBox();
            panel_icetea.Controls.Add(label_icetea);
            panel_icetea.Controls.Add(prix_icetea);
            panel_icetea.Controls.Add(pictureBox_icetea);
            pictureBox_icetea.Image = Properties.Resources.icetea;
            pictureBox_icetea.Location = new Point(104, 85);
            pictureBox_icetea.Height = 215;
            pictureBox_icetea.Width = 215;
            pictureBox_icetea.SizeMode = PictureBoxSizeMode.Zoom;
            label_icetea.AutoSize = true;
            prix_icetea.AutoSize = true;
            label_icetea.Font = police;
            prix_icetea.Font = police;
            label_icetea.Location = new Point(25, 25);
            prix_icetea.Location = new Point(25, 334);
            label_icetea.Text = "Ice Tea";
            prix_icetea.Text = "Prix : " + stockageinit.prixconfis["Icetea"] + " €";

            panel_icetea.Location = new Point(81, 50);
            panel_icetea.Width = 423;
            panel_icetea.Height = 390;
            panel_icetea.BackColor = Color.FromArgb(227, 230, 237);
            panel_icetea.Hide();

            this.Controls.Add(panel_coca);

            Label label_coca = new Label();
            Label prix_coca = new Label();
            PictureBox pictureBox_coca = new PictureBox();
            panel_coca.Controls.Add(label_coca);
            panel_coca.Controls.Add(prix_coca);
            panel_coca.Controls.Add(pictureBox_coca);
            pictureBox_coca.Image = Properties.Resources.coca;
            pictureBox_coca.Location = new Point(104, 85);
            pictureBox_coca.Height = 215;
            pictureBox_coca.Width = 215;
            pictureBox_coca.SizeMode = PictureBoxSizeMode.Zoom;
            label_coca.AutoSize = true;
            prix_coca.AutoSize = true;
            label_coca.Font = police;
            prix_coca.Font = police;
            label_coca.Location = new Point(25, 25);
            prix_coca.Location = new Point(25, 334);
            label_coca.Text = "Coca-Cola";
            prix_coca.Text = "Prix : " + stockageinit.prixconfis["Coca"] + " €";

            panel_coca.Location = new Point(585, 50);
            panel_coca.Width = 423;
            panel_coca.Height = 390;
            panel_coca.BackColor = Color.FromArgb(227, 230, 237);
            panel_coca.Hide();

            this.Controls.Add(panel_sprite);

            Label label_sprite = new Label();
            Label prix_sprite = new Label();
            PictureBox pictureBox_sprite = new PictureBox();
            panel_sprite.Controls.Add(label_sprite);
            panel_sprite.Controls.Add(prix_sprite);
            panel_sprite.Controls.Add(pictureBox_sprite);
            pictureBox_sprite.Image = Properties.Resources.sprite;
            pictureBox_sprite.Location = new Point(104, 85);
            pictureBox_sprite.Height = 215;
            pictureBox_sprite.Width = 215;
            pictureBox_sprite.SizeMode = PictureBoxSizeMode.Zoom;
            label_sprite.AutoSize = true;
            prix_sprite.AutoSize = true;
            label_sprite.Font = police;
            prix_sprite.Font = police;
            label_sprite.Location = new Point(25, 25);
            prix_sprite.Location = new Point(25, 334);
            label_sprite.Text = "Sprite";
            prix_sprite.Text = "Prix : " + stockageinit.prixconfis["Sprite"] + " €";

            panel_sprite.Location = new Point(1089, 50);
            panel_sprite.Width = 423;
            panel_sprite.Height = 390;
            panel_sprite.BackColor = Color.FromArgb(227, 230, 237);
            panel_sprite.Hide();

            this.Controls.Add(panel_fanta);

            Label label_fanta = new Label();
            Label prix_fanta = new Label();
            PictureBox pictureBox_fanta = new PictureBox();
            panel_fanta.Controls.Add(label_fanta);
            panel_fanta.Controls.Add(prix_fanta);
            panel_fanta.Controls.Add(pictureBox_fanta);
            pictureBox_fanta.Image = Properties.Resources.fanta;
            pictureBox_fanta.Location = new Point(104, 85);
            pictureBox_fanta.Height = 215;
            pictureBox_fanta.Width = 215;
            pictureBox_fanta.SizeMode = PictureBoxSizeMode.Zoom;
            label_fanta.AutoSize = true;
            prix_fanta.AutoSize = true;
            label_fanta.Font = police;
            prix_fanta.Font = police;
            label_fanta.Location = new Point(25, 25);
            prix_fanta.Location = new Point(25, 334);
            label_fanta.Text = "Fanta";
            prix_fanta.Text = "Prix : " + stockageinit.prixconfis["Fanta"] + " €";

            panel_fanta.Location = new Point(81, 490);
            panel_fanta.Width = 423;
            panel_fanta.Height = 390;
            panel_fanta.BackColor = Color.FromArgb(227, 230, 237);
            panel_fanta.Hide();

            this.Controls.Add(panel_eau);

            Label label_eau = new Label();
            Label prix_eau = new Label();
            PictureBox pictureBox_eau = new PictureBox();
            panel_eau.Controls.Add(label_eau);
            panel_eau.Controls.Add(prix_eau);
            panel_eau.Controls.Add(pictureBox_eau);
            pictureBox_eau.Image = Properties.Resources.eau;
            pictureBox_eau.Location = new Point(104, 85);
            pictureBox_eau.Height = 215;
            pictureBox_eau.Width = 215;
            pictureBox_eau.SizeMode = PictureBoxSizeMode.Zoom;
            label_eau.AutoSize = true;
            prix_eau.AutoSize = true;
            label_eau.Font = police;
            prix_eau.Font = police;
            label_eau.Location = new Point(25, 25);
            prix_eau.Location = new Point(25, 334);
            label_eau.Text = "Eau";
            prix_eau.Text = "Prix : " + stockageinit.prixconfis["Eau"] + " €";

            panel_eau.Location = new Point(585, 490);
            panel_eau.Width = 423;
            panel_eau.Height = 390;
            panel_eau.BackColor = Color.FromArgb(227, 230, 237);
            panel_eau.Hide();

            this.Controls.Add(panel_caprisun);

            Label label_caprisun = new Label();
            Label prix_caprisun = new Label();
            PictureBox pictureBox_caprisun = new PictureBox();
            panel_caprisun.Controls.Add(label_caprisun);
            panel_caprisun.Controls.Add(prix_caprisun);
            panel_caprisun.Controls.Add(pictureBox_caprisun);
            pictureBox_caprisun.Image = Properties.Resources.caprisun;
            pictureBox_caprisun.Location = new Point(104, 85);
            pictureBox_caprisun.Height = 215;
            pictureBox_caprisun.Width = 215;
            pictureBox_caprisun.SizeMode = PictureBoxSizeMode.Zoom;
            label_caprisun.AutoSize = true;
            prix_caprisun.AutoSize = true;
            label_caprisun.Font = police;
            prix_caprisun.Font = police;
            label_caprisun.Location = new Point(25, 25);
            prix_caprisun.Location = new Point(25, 334);
            label_caprisun.Text = "Caprisun";
            prix_caprisun.Text = "Prix : " + stockageinit.prixconfis["Caprisun"] + " €";

            panel_caprisun.Location = new Point(1089, 490);
            panel_caprisun.Width = 423;
            panel_caprisun.Height = 390;
            panel_caprisun.BackColor = Color.FromArgb(227, 230, 237);
            panel_caprisun.Hide();

            //menu
            this.Controls.Add(panel_grande_for);

            Label label_grande_for = new Label();
            Label prix_grande_for = new Label();
            PictureBox pictureBox_grande_for = new PictureBox();
            panel_grande_for.Controls.Add(label_grande_for);
            panel_grande_for.Controls.Add(prix_grande_for);
            panel_grande_for.Controls.Add(pictureBox_grande_for);
            pictureBox_grande_for.Image = Properties.Resources.Menu;
            pictureBox_grande_for.Location = new Point(104, 85);
            pictureBox_grande_for.Height = 215;
            pictureBox_grande_for.Width = 215;
            pictureBox_grande_for.SizeMode = PictureBoxSizeMode.Zoom;
            label_grande_for.AutoSize = true;
            prix_grande_for.AutoSize = true;
            label_grande_for.Font = police;
            prix_grande_for.Font = police;
            label_grande_for.Location = new Point(25, 25);
            prix_grande_for.Location = new Point(25, 334);
            label_grande_for.Text = "Grande Formule (Pop Corn (L)\n+ Boisson)";
            prix_grande_for.Text = "Prix : " + stockageinit.prixconfis["Grande_formule"] + " €";

            panel_grande_for.Location = new Point(81, 50);
            panel_grande_for.Width = 423;
            panel_grande_for.Height = 390;
            panel_grande_for.BackColor = Color.FromArgb(227, 230, 237);
            panel_grande_for.Hide();

            this.Controls.Add(panel_moyenne_for);

            Label label_moyenne_for = new Label();
            Label prix_moyenne_for = new Label();
            PictureBox pictureBox_moyenne_for = new PictureBox();
            panel_moyenne_for.Controls.Add(label_moyenne_for);
            panel_moyenne_for.Controls.Add(prix_moyenne_for);
            panel_moyenne_for.Controls.Add(pictureBox_moyenne_for);
            pictureBox_moyenne_for.Image = Properties.Resources.Menu;
            pictureBox_moyenne_for.Location = new Point(104, 85);
            pictureBox_moyenne_for.Height = 215;
            pictureBox_moyenne_for.Width = 215;
            pictureBox_moyenne_for.SizeMode = PictureBoxSizeMode.Zoom;
            label_moyenne_for.AutoSize = true;
            prix_moyenne_for.AutoSize = true;
            label_moyenne_for.Font = police;
            prix_moyenne_for.Font = police;
            label_moyenne_for.Location = new Point(25, 25);
            prix_moyenne_for.Location = new Point(25, 334);
            label_moyenne_for.Text = "Formule Moyenne (Pop Corn\n(M) + Boisson)";
            prix_moyenne_for.Text = "Prix : " + stockageinit.prixconfis["Moyenne_formule"] + " €";

            panel_moyenne_for.Location = new Point(585, 50);
            panel_moyenne_for.Width = 423;
            panel_moyenne_for.Height = 390;
            panel_moyenne_for.BackColor = Color.FromArgb(227, 230, 237);
            panel_moyenne_for.Hide();

            this.Controls.Add(panel_petite_for);

            Label label_petite_for = new Label();
            Label prix_petite_for = new Label();
            PictureBox pictureBox_petite_for = new PictureBox();
            panel_petite_for.Controls.Add(label_petite_for);
            panel_petite_for.Controls.Add(prix_petite_for);
            panel_petite_for.Controls.Add(pictureBox_petite_for);
            pictureBox_petite_for.Image = Properties.Resources.Menu;
            pictureBox_petite_for.Location = new Point(104, 85);
            pictureBox_petite_for.Height = 215;
            pictureBox_petite_for.Width = 215;
            pictureBox_petite_for.SizeMode = PictureBoxSizeMode.Zoom;
            label_petite_for.AutoSize = true;
            prix_petite_for.AutoSize = true;
            label_petite_for.Font = police;
            prix_petite_for.Font = police;
            label_petite_for.Location = new Point(25, 25);
            prix_petite_for.Location = new Point(25, 334);
            label_petite_for.Text = "Petite Formule (Pop Corn (S)\n+ Boisson)";
            prix_petite_for.Text = "Prix : " + stockageinit.prixconfis["Petite_formule"] + " €";

            panel_petite_for.Location = new Point(1089, 50);
            panel_petite_for.Width = 423;
            panel_petite_for.Height = 390;
            panel_petite_for.BackColor = Color.FromArgb(227, 230, 237);
            panel_petite_for.Hide();

            this.Controls.Add(panel_glace_for);

            Label label_glace_for = new Label();
            Label prix_glace_for = new Label();
            PictureBox pictureBox_glace_for = new PictureBox();
            panel_glace_for.Controls.Add(label_glace_for);
            panel_glace_for.Controls.Add(prix_glace_for);
            panel_glace_for.Controls.Add(pictureBox_glace_for);
            pictureBox_glace_for.Image = Properties.Resources.Menuglace;
            pictureBox_glace_for.Location = new Point(104, 85);
            pictureBox_glace_for.Height = 215;
            pictureBox_glace_for.Width = 215;
            pictureBox_glace_for.SizeMode = PictureBoxSizeMode.Zoom;
            label_glace_for.AutoSize = true;
            prix_glace_for.AutoSize = true;
            label_glace_for.Font = police;
            prix_glace_for.Font = police;
            label_glace_for.Location = new Point(25, 25);
            prix_glace_for.Location = new Point(25, 334);
            label_glace_for.Text = "Formule Glace (Glace\n+Boisson)";
            prix_glace_for.Text = "Prix : " + stockageinit.prixconfis["Formule_Glace"] + " €";

            panel_glace_for.Location = new Point(81, 490);
            panel_glace_for.Width = 423;
            panel_glace_for.Height = 390;
            panel_glace_for.BackColor = Color.FromArgb(227, 230, 237);
            panel_glace_for.Hide();
            //confiserie
            foreach (Control childControl in panel_grand_popcorn_sale.Controls)
            {
                childControl.Click += new EventHandler(panel_grand_popcorn_sale_Click);
            }
            foreach (Control childControl in panel_moyen_popcorn_sale.Controls)
            {
                childControl.Click += new EventHandler(panel_moyen_popcorn_sale_Click);
            }
            foreach (Control childControl in panel_petit_popcorn_sale.Controls)
            {
                childControl.Click += new EventHandler(panel_petit_popcorn_sale_Click);
            }
            foreach (Control childControl in panel_bonbon.Controls)
            {
                childControl.Click += new EventHandler(panel_bonbon_Click);
            }
            foreach (Control childControl in panel_mms.Controls)
            {
                childControl.Click += new EventHandler(panel_mms_Click);

            }
            foreach (Control childControl in panel_glace.Controls)
            {
                childControl.Click += new EventHandler(panel_glace_Click);
            }
            //boisson
            foreach (Control childControl in panel_icetea.Controls)
            {
                childControl.Click += new EventHandler(panel_icetea_Click);
            }
            foreach (Control childControl in panel_coca.Controls)
            {
                childControl.Click += new EventHandler(panel_coca_Click);
            }
            foreach (Control childControl in panel_sprite.Controls)
            {
                childControl.Click += new EventHandler(panel_sprite_Click);
            }
            foreach (Control childControl in panel_fanta.Controls)
            {
                childControl.Click += new EventHandler(panel_fanta_Click);
            }
            foreach (Control childControl in panel_eau.Controls)
            {
                childControl.Click += new EventHandler(panel_eau_Click);
            }
            foreach (Control childControl in panel_caprisun.Controls)
            {
                childControl.Click += new EventHandler(panel_caprisun_Click);
            }
            //menue
            foreach (Control childControl in panel_grande_for.Controls)
            {
                childControl.Click += new EventHandler(panel_grande_for_Click);
            }
            foreach (Control childControl in panel_moyenne_for.Controls)
            {
                childControl.Click += new EventHandler(panel_moyenne_for_Click);
            }
            foreach (Control childControl in panel_petite_for.Controls)
            {
                childControl.Click += new EventHandler(panel_petite_for_Click);
            }
            foreach (Control childControl in panel_glace_for.Controls)
            {
                childControl.Click += new EventHandler(panel_glace_for_Click);
            }
        }

        //déclaration des action lorsque l'on click sur les panels et ce qu'il y a dedans
        public void panel_grand_popcorn_sale_Click(object sender, EventArgs e) 
        {
            panel_grand_popcorn_sale.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_grand_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Grand_popcorn_sale"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_moyen_popcorn_sale_Click(object sender, EventArgs e)
        {
            panel_moyen_popcorn_sale.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_moyen_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Moyen_popcorn_sale"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_petit_popcorn_sale_Click(object sender, EventArgs e)
        {
            panel_petit_popcorn_sale.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_petit_popcorn_sale.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Petit_popcorn_sale"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_bonbon_Click(object sender, EventArgs e)
        {
            panel_bonbon.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_bonbon.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Bonbon"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_mms_Click(object sender, EventArgs e)
        {
            panel_mms.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_mms.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["MM's"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_glace_Click(object sender, EventArgs e)
        {
            panel_glace.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_glace.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Glace"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        //boisson
        public void panel_icetea_Click(object sender, EventArgs e)
        {
            panel_icetea.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_icetea.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Icetea"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_coca_Click(object sender, EventArgs e)
        {
            panel_coca.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_coca.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Coca"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_sprite_Click(object sender, EventArgs e)
        {
            panel_sprite.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_sprite.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Sprite"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_fanta_Click(object sender, EventArgs e)
        {
            panel_fanta.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_fanta.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Fanta"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_eau_Click(object sender, EventArgs e)
        {
            panel_eau.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_eau.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Eau"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_caprisun_Click(object sender, EventArgs e)
        {
            panel_caprisun.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_caprisun.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Caprisun"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        //menu
        public void panel_grande_for_Click(object sender, EventArgs e)
        {
            panel_grande_for.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_grande_for.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Grande_formule"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_moyenne_for_Click(object sender, EventArgs e)
        {
            panel_moyenne_for.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_moyenne_for.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Moyenne_formule"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_petite_for_Click(object sender, EventArgs e)
        {
            panel_petite_for.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_petite_for.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Petite_formule"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void panel_glace_for_Click(object sender, EventArgs e)
        {
            panel_glace_for.BackColor = SystemColors.ControlDark;

            // Attendre une fraction de seconde pour donner un effet de transition
            Task.Delay(100).ContinueWith(_ =>
            {
                // Rétablir l'apparence normale du panneau après un court délai
                panel_glace_for.BackColor = Color.FromArgb(227, 230, 237);
            }, TaskScheduler.FromCurrentSynchronizationContext());

            stockagetemp.list_confis["Formule_Glace"]++;
            MainPage parentControl = this.Parent as MainPage;
            parentControl.lepanier.Actualisationpanier();
        }
        public void affiche_menu() //affichage des panels pour les menues
        {
            enleve_banieres();
            panel_grande_for.Show();
            panel_moyenne_for.Show();
            panel_petite_for.Show();
            panel_glace_for.Show();

        }
        public void affiche_boisson()//affichage des panels pour les boissons
        {
            enleve_banieres();
            panel_icetea.Show();
            panel_coca.Show();
            panel_sprite.Show();
            panel_fanta.Show();
            panel_eau.Show();
            panel_caprisun.Show();
        }
        public void affiche_confiserie()//affichage des panels pour les sucreries
        {
            enleve_banieres();
            panel_grand_popcorn_sale.Show();
            panel_moyen_popcorn_sale.Show();
            panel_petit_popcorn_sale.Show();
            panel_glace.Show();
            panel_mms.Show();
            panel_bonbon.Show();
        }

        public void enleve_banieres() //enlève les 3 premières bannières
        {
            panel_boisson.Hide();
            panel_menu.Hide();
            panel_confiserie.Hide();
            buttonprecedent.Visible = true;
        }

        public void panel_menu_click(object sender, EventArgs e)
        {
            affiche_menu();
        }
        public void panel_boisson_click(object sender, EventArgs e)
        {
            affiche_boisson();
        }
        public void panel3_confiserie_click(object sender, EventArgs e)
        {
            affiche_confiserie();
        }

        public class RoundedPanel : Panel //classe pour faire un panel arrondi
        {
            private int m_width;
            private int m_height;

            public RoundedPanel()
            {
                m_width = 90;
                m_height = 90;
            }

            public RoundedPanel(int width, int height)
            {
                m_width = width;
                m_height = height;
            }

            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
             );

            protected override void OnResize(EventArgs e)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width + 1, Height + 1, m_width, m_height));
                base.OnResize(e);
            }
        }

        public class RoundedButton : Button//classe pour faire un bouton arrondi
        {
            private int m_width;
            private int m_height;

            public RoundedButton()
            {
                m_width = 30;
                m_height = 30;
            }

            public RoundedButton(int width, int height)
            {
                m_width = width;
                m_height = height;
            }

            [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect, // x-coordinate of upper-left corner
                int nTopRect, // y-coordinate of upper-left corner
                int nRightRect, // x-coordinate of lower-right corner
                int nBottomRect, // y-coordinate of lower-right corner
                int nWidthEllipse, // height of ellipse
                int nHeightEllipse // width of ellipse
             );

            protected override void OnResize(EventArgs e)
            {
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width + 1, Height + 1, m_width, m_height));
                base.OnResize(e);
            }
        }
        private void button1_Click(object sender, EventArgs e) //action lors du click sur le bouton retour
        {
            if (panel_boisson.Visible != true)
            {
                efface_tout();
                panel_boisson.Show();
                panel_confiserie.Show();
                panel_menu.Show();
                buttonprecedent.Visible = false;
            }

        }

        public void efface_tout() //cache tous les panels
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel)
                {
                    c.Hide();
                }
            }
        }

    }
}
