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

        public MainForm()
        {
            InitializeComponent();
            currentPlayer = new Player();
            mainGame = new MainGame();
            textBoxMise.Text = string.Format("{0}€", mainGame.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", currentPlayer.MyBet);
        }

        private void PickCard()
        {
            var animator = ImageSpriteGenerator.getInstance();
            var card = animator.cardsGame[mainGame.GetIndex()];
            currentPlayer.MyCards.Add(card);
            this.Controls.Add(new PictureBox()
            {
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Image,
                Location = new Point(this.Width / 4 + (currentPlayer.MyCards.Count * 40), 2 * (this.Height / 3))
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickCard();
        }

        private void MAJ() {
            textBoxMise.Text = string.Format("{0}€", mainGame.GeneralBet);
            textBox_Account.Text = string.Format("{0}€", currentPlayer.MyBet);
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_bet_Click(object sender, EventArgs e)
        {
            currentPlayer.MyBet -= 20;
            mainGame.GeneralBet += 20;
            this.button_bet.Visible = false;
            this.button_pick.Visible = true;
            for (int i = 0; i < 2; i++)
            {
                PickCard();
            }
            MAJ();
        }
    }
}
