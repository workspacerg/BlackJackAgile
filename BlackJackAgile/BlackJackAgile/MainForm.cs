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
            game = new Game();
            textBoxMise.Text = string.Format("{0}€", game.croupier.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", game.player.MyBet);
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
            var animator = ImageSpriteGenerator.getInstance();
            int idx = game.croupier.GetIndex();
            var card = animator.cardsGame[idx];
            card.Visible = isVisible;
            game.croupier.Cards.Add(card);

            this.Controls.Add(new PictureBox()
            {
                Name = string.Format("Croupier_{0}", idx),
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Visible ? card.Image : animator.hideCard.Image,
                Location = new Point(this.Width / 4 + (game.croupier.Cards.Count * 40), heightCroupier)
            });
        }

        /// <summary>
        /// Lorsque le joueur tire une carte
        /// </summary>
        private void PickCardPlayer()
        {
            var animator = ImageSpriteGenerator.getInstance();
            int idx = game.croupier.GetIndex();
            var card = animator.cardsGame[idx];
            game.player.Cards.Add(card);

            this.Controls.Add(new PictureBox()
            {
                Name = string.Format("Player_{0}", idx),
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Image,
                Location = new Point(this.Width / 4 + (game.player.Cards.Count * 40), heightPlayer)
            });
        }

        /// <summary>
        /// Donner Une carte au joueur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PickCardPlayer();
            var checkSum = game.CheckSum();
            if (checkSum.Equals(StatePick.LOSE)) // Fin du jeu, joueur a perdu
                RestartGame();
            else if (checkSum.Equals(StatePick.WIN))
                game.LaunchEndGame();
        }

        private void RestartGame()
        {
            if (game.player.MyBet == 0) {
                new EndGame().ShowDialog(this);
                return;
            }
            ResetPictureBox();
            game.ResetCards();
            this.button_bet.Visible = true;
            game.isLaunched = false;
            this.button_pick.Visible = this.buttonReste.Visible = false;
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
            textBoxMise.Text = string.Format("{0}€", game.croupier.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", game.player.MyBet);
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
            if (game.croupier.GeneralBet == 0)
            {
                MessageBox.Show("Veuillez miser avant de jouer");
                return;
            }

            game.isLaunched = true;
            this.button_bet.Visible = false;
            this.button_pick.Visible = this.buttonReste.Visible = true;
            bool firstCard = false;
            for (int i = 0; i < 2; i++)
            {
                PickCardPlayer();
                PickCardCroupier(firstCard = !firstCard);
            }
        }

        private void buttonReste_Click(object sender, EventArgs e)
        {
            game.LaunchEndGame();
        }
    }
}
