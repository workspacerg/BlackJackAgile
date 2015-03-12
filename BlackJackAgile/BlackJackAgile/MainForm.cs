using System;
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
        private Game game;

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

            game = new Game(this,heightCroupier,heightPlayer);
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
        }

        /// <summary>
        /// Lorsque le joueur tire une carte
        /// </summary>
        private void PickCardPlayer()
        {
            game.PickCardPlayer();
        }

        /// <summary>
        /// Donner Une carte au joueur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PickCardPlayer();
            GetState();
        }

        private void GetState() {
            var sum = game.player.GetPoints();
            if (sum > 21)
            {
                MessageBox.Show(string.Format("Vous êtes à {0}. Vous avez perdu !", sum));
                RestartGame();
            }
            else if (sum == 21)
            {
                MessageBox.Show(string.Format("Vous êtes à {0}. Place au croupier !", sum));
                game.LaunchEndGame();
            }
        }

        public void RestartGame()
        {
            if (game.player.MyBet == 0) {
                new EndGame().ShowDialog(this);
                return;
            }
            ResetPictureBox();
            game.ResetCards();
            this.button_bet.Visible = true;
            game.isLaunched = false;
            this.button_pick.Visible = this.buttonReste.Visible = this.button_double.Visible = false;
            MAJ();
        }

        private void ResetPictureBox()
        {
            var pb = new List<PictureBox>();
            foreach (var c in this.Controls) {
                if (c is PictureBox && !(c as PictureBox).Name.StartsWith("pictureBox_j"))
                    pb.Add(c as PictureBox);
            }
            pb.ForEach(x => this.Controls.Remove(x));
        }

        private void MAJ()
        {
            label_mise.Text = string.Format("{0}€", game.currentBet);
            label_compte.Text = string.Format("{0}€", game.player.MyBet);
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
        private void button_bet_Click(object sender, EventArgs e)
        {
            if (game.isLaunched)
                return;
            if (game.currentBet == 0)
            {
                MessageBox.Show("Veuillez miser avant de jouer");
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
        }

        private void buttonReste_Click(object sender, EventArgs e)
        {
            this.buttonReste.Visible = this.button_pick.Visible = false;
            game.LaunchEndGame();
        }

        /// <summary>
        /// Doubler la mise
        /// </summary>
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (game.currentBet>game.player.MyBet)
            {
                MessageBox.Show("Vous n'avez pas assez d'argent pour doubler ... ");
                return;
            }
            game.Double();
            PickCardPlayer();
            this.button_double.Visible = this.button_pick.Visible = this.buttonReste.Visible = false;
            MAJ();
            GetState();
            game.LaunchEndGame();
        }
    }
}
