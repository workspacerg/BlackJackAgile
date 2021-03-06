﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJackAgile
{
    public partial class MainForm : Form
    {
        public Game game { get; set; }

        private static int heightPlayer;

        private static int heightCroupier;

        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint | ControlStyles.ResizeRedraw,
            true);

            InitGame();
        }

        private void InitGame()
        {
            heightPlayer = 3 * (this.Height / 6);
            heightCroupier = this.Height / 3;

            game = new Game(this, heightCroupier, heightPlayer);
            label_mise.Text = string.Format("{0}€", game.currentBet);
            label_compte.Text = string.Format("{0}€", game.player.MyBet);
            InitEventsChips();
        }

        private void InitEventsChips()
        {
            this.pictureBox_j5.Click += (sender, e) => pictureBox_j_Click(sender, e, 5);
            this.pictureBox_j10.Click += (sender, e) => pictureBox_j_Click(sender, e, 10);
            this.pictureBox_j25.Click += (sender, e) => pictureBox_j_Click(sender, e, 25);
            this.pictureBox_j50.Click += (sender, e) => pictureBox_j_Click(sender, e, 50);
        }

        void pictureBox_j_Click(object sender, EventArgs e, int value)
        {
            game.DoBetOrUnbet(((MouseEventArgs)e), value);
            MAJ();
        }

        /// <summary>
        /// Lorsque le croupier tire une carte
        /// </summary>
        /// <param name="isVisible">Indique si la carte est visible ou non</param>
        private void PickCardCroupier(bool isVisible)
        {
            game.PickCardCroupier(isVisible);
            MAJ();
        }

        /// <summary>
        /// Lorsque le joueur tire une carte
        /// </summary>
        private void PickCardPlayer()
        {
            game.PickCardPlayer();
            MAJ();
        }

        /// <summary>
        /// Donner Une carte au joueur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PickCardPlayer();
            this.button_double.Visible = false; // Dès qu'on tire une carte on peut plus doubler
            GetState();

        }

        private void GetState()
        {
            var sum = game.player.GetPoints();
            if (sum > 21)
            {
                this.label_Main.Text = string.Format("Vous êtes à {0}. Vous avez perdu !", sum);
                game.isLaunched = false;
                this.button_continue.Visible = true;
                this.button_double.Visible = this.button_pick.Visible = this.buttonReste.Visible = false;
            }
            else if (sum == 21)
            {
                this.button_double.Visible = this.button_pick.Visible = this.buttonReste.Visible = false;
                this.label_Main.Text = string.Format("Vous êtes à 21. Place au croupier !");
                System.Threading.Thread.Sleep(1000);
                game.LaunchEndGame();
            }
        }

        public void RestartGame()
        {
            if (game.player.MyBet == 0)
            {
                new EndGame().ShowDialog(this);
                return;
            }
            ResetPictureBox();
            game.ResetCards();
            this.button_bet.Visible = true;
            game.isLaunched = false;
            this.button_pick.Visible = this.buttonReste.Visible = this.button_double.Visible = false;
            this.label_Main.Text = "Miser pour jouer !";
            MAJ();
        }

        private void ResetPictureBox()
        {
            var pb = new List<PictureBox>();
            foreach (var c in this.Controls)
            {
                if (c is PictureBox && !(c as PictureBox).Name.StartsWith("pictureBox_j"))
                    pb.Add(c as PictureBox);
            }
            pb.ForEach(x => this.Controls.Remove(x));
        }

        public void MAJ()
        {
            label_mise.Text = string.Format("{0}€", game.currentBet);
            label_compte.Text = string.Format("{0}€", game.player.MyBet);
            score_joueur.Text = string.Format("Joueur : {0}", game.player.GetPoints());
            score_banque.Text = string.Format("Banque : {0}", game.croupier.GetPoints());
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Donner les cartes au joueur et au croupier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void button_bet_Click(object sender, EventArgs e)
        {
            if (game.isLaunched)
                return;
            if (game.currentBet == 0)
            {
                this.label_Main.Text = "Veuillez miser avant de jouer";
                return;
            }

            game.isLaunched = true;
            this.button_bet.Visible = false;
            this.button_pick.Visible = this.buttonReste.Visible = this.button_double.Visible = true;
            bool firstCard = false;
            for (int i = 0; i < 2; i++)
            {
                PickCardPlayer();
                PickCardCroupier(firstCard = !firstCard);
            }
            GetState();
            this.label_Main.Text = "Partie en cours ...";
        }

        private void buttonReste_Click(object sender, EventArgs e)
        {
            this.buttonReste.Visible = this.button_pick.Visible = this.button_double.Visible = false;
            game.LaunchEndGame();
        }

        /// <summary>
        /// Doubler la mise
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (game.currentBet > game.player.MyBet)
            {
                this.label_Main.Text = "Vous n'avez pas assez d'argent pour doubler ... ";
                return;
            }
            game.Double();
            PickCardPlayer();
            this.button_double.Visible = this.button_pick.Visible = this.buttonReste.Visible = false;
            MAJ();
            GetState();
            if (game.isLaunched)
                game.LaunchEndGame();                
        }

        private void button_continue_Click(object sender, EventArgs e)
        {
            RestartGame();
            button_continue.Visible = false;
        }

    }
}
