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
        private Player currentPlayer;

        private MainGame mainGame;

        private static int heightPlayer;

        private static int heightCroupier;

        public MainForm()
        {
            InitializeComponent();
            currentPlayer = new Player();
            mainGame = new MainGame();
            textBoxMise.Text = string.Format("{0}€", mainGame.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", currentPlayer.MyBet);
            heightPlayer = 2 * (this.Height / 3);
            heightCroupier = this.Height / 3;
            InitEventsChips();
        }

        private void InitEventsChips() {
            this.pictureBox_j5.Click += (sender, e) => pictureBox_j_Click(sender, e,5);
            this.pictureBox_j10.Click += (sender, e) => pictureBox_j_Click(sender, e, 10);
            this.pictureBox_j25.Click += (sender, e) => pictureBox_j_Click(sender, e,25);
            this.pictureBox_j50.Click += (sender, e) => pictureBox_j_Click(sender, e, 50);
        }

        void pictureBox_j_Click(object sender, EventArgs e,int value)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                currentPlayer.MyBet -= value;
                mainGame.GeneralBet += value;
            }
            else {
                currentPlayer.MyBet += value;
                mainGame.GeneralBet -= value;
            }

            this.button_bet.Visible = false;
            this.button_pick.Visible = true;
            bool firstCard = true;
            for (int i = 0; i < 2; i++)
            {
                PickCardPlayer();
                PickCardCroupier(firstCard = !firstCard);
            }
            MAJ();
        }

        /// <summary>
        /// Lorsque le croupier tire une carte
        /// </summary>
        /// <param name="isVisible">Indique si la carte est visible ou non</param>
        private void PickCardCroupier(bool isVisible)
        {
            var animator = ImageSpriteGenerator.getInstance();
            var card = animator.cardsGame[mainGame.GetIndex()];
            mainGame.CardsGame.Add(card);
            this.Controls.Add(new PictureBox()
            {
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = isVisible ? card.Image : animator.hideCard.Image,
                Location = new Point(this.Width / 4 + (mainGame.CardsGame.Count * 40), heightCroupier)
            });
        }

        /// <summary>
        /// Lorsque le joueur tire une carte
        /// </summary>
        private void PickCardPlayer()
        {
            var animator = ImageSpriteGenerator.getInstance();
            var card = animator.cardsGame[mainGame.GetIndex()];
            currentPlayer.MyCards.Add(card);
            
            //MessageBox.Show("Player pts : "+currentPlayer.getPtsPlayer());
            this.Controls.Add(new PictureBox()
            {
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Image,
                Location = new Point(this.Width / 4 + (currentPlayer.MyCards.Count * 40), heightPlayer)
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
            if (currentPlayer.MyCards.Sum(x => x.Value) >= 21)
                MessageBox.Show("OKLM T'ES A 21 MEC");
        }

        private void MAJ()
        {
            textBoxMise.Text = string.Format("{0}€", mainGame.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", currentPlayer.MyBet);
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
            
        }
    }
}
