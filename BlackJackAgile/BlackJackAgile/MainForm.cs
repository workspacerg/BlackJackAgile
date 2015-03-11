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
            heightPlayer = 3 * (this.Height / 5);
            heightCroupier = this.Height / 3;
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

            if (((MouseEventArgs)e).Button == MouseButtons.Left)
            {
                if (currentPlayer.MyBet < value)
                {
                    MessageBox.Show(String.Format("Vous n'avez pas assez d'argent pour miser {0}€",value));
                    return;
                }
                currentPlayer.MyBet -= value;
                mainGame.GeneralBet += value;
            }
            else
            {
                if (mainGame.GeneralBet < value) {
                    MessageBox.Show(String.Format("Vous ne pouvez pas récupérer {0}€",value));
                    return;
                }
                currentPlayer.MyBet += value;
                mainGame.GeneralBet -= value;
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
            mainGame.Cards.Add(card);
            this.Controls.Add(new PictureBox()
            {
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = isVisible ? card.Image : animator.hideCard.Image,
                Location = new Point(this.Width / 4 + (mainGame.Cards.Count * 40), heightCroupier)
            });
        }

        /// <summary>
        /// Lorsque le joueur tire une carte
        /// </summary>
        private void PickCardPlayer()
        {
            var animator = ImageSpriteGenerator.getInstance();
            var card = animator.cardsGame[mainGame.GetIndex()];
            currentPlayer.Cards.Add(card);

            this.Controls.Add(new PictureBox()
            {
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Image,
                Location = new Point(this.Width / 4 + (currentPlayer.Cards.Count * 40), heightPlayer)
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
            if (currentPlayer.Cards.Sum(x => x.Value) >= 21)
                MessageBox.Show("OKLM T'ES A 21 MEC");
        }

        private void MAJ()
        {
            textBoxMise.Text = string.Format("{0}€", mainGame.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", currentPlayer.MyBet);
        }

        /// <summary>
        /// Donner les cartes au joueur et au croupier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_bet_Click(object sender, EventArgs e)
        {
            if (mainGame.GeneralBet == 0)
            {
                MessageBox.Show("Veuillez misez de l'argent avant de lancer la partie");
                return;
            }
            this.button_bet.Visible = false;
            this.button_pick.Visible = true;
            bool firstCard = true;
            for (int i = 0; i < 2; i++)
            {
                PickCardPlayer();
                PickCardCroupier(firstCard = !firstCard);
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            heightPlayer = 3 * (this.Height / 5);
            heightCroupier = this.Height / 3;
        }
    }
}
