using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace BlackJackAgile
{
    public class Game
    {

        public int currentBet { get; set; }

        public Player player { get; set; }

        public MainGame croupier { get; set; }

        public bool isLaunched { get; set; }

        private Timer timer;

        private MainForm form;

        private int heightCroupier;

        private int heightPlayer;

        public Game(MainForm form, int heightC, int heightP)
        {
            player = new Player();
            croupier = new MainGame();
            heightCroupier = heightC;
            heightPlayer = heightP;
            timer = new Timer();
            timer.Interval = 500;
            timer.Tick += new EventHandler(timer_Tick);
            this.form = form;
        }

        void timer_Tick(object sender, EventArgs e)
        {
            PickCardCroupier(true);
            if (croupier.GetPoints() > 21)
            {
                MessageBox.Show("Le croupier a dépassé 21, vous avez gagné");
                timer.Stop();
            }
        }

        public Game() {
            player = new Player();
            croupier = new MainGame();
            currentBet = 0;
        }

        public void DoBetOrUnbet(MouseEventArgs e, int value) {
            if (isLaunched)
                return;

            int tempPlayerBet = player.MyBet;

            if (e.Button == MouseButtons.Left)
            {
                if (player.MyBet < value)
                {
                    MessageBox.Show(String.Format("Vous n'avez pas assez d'argent pour miser {0}€", value));
                    return;
                }
                player.MyBet -= value;
                croupier.GeneralBet += value;
            }
            else
            {
                if (croupier.GeneralBet < value)
                {
                    MessageBox.Show(String.Format("Vous ne pouvez pas récupérer {0}€", value));
                    return;
                }
                player.MyBet += value;
                croupier.GeneralBet -= value;
            }
            currentBet = tempPlayerBet - player.MyBet;
        }

        public StatePick CheckSum()
        {
            var pts = player.GetPoints();
            if (pts > 21)
            {
                MessageBox.Show(string.Format("Vous êtes à {0}. Vous avez perdu !", pts));
                return StatePick.LOSE;
            }
            if (pts == 21)
            {
                MessageBox.Show(string.Format("Vous êtes à {0}. Place au croupier !", pts));
                return StatePick.WIN;
            }

            return StatePick.NONE;
        }

        public void Reset()
        {
            player.Reset();
            croupier.Reset();
        }

        // Fonction quand le joueur dis je reste ou est à 21 (le croupier fait son taff)
        public void LaunchEndGame()
        {
            BackCard(form);
        }

        public void PickCardPlayer()
        {
            var animator = ImageSpriteGenerator.getInstance();
            int idx = croupier.GetIndex();
            var card = animator.cardsGame[idx];
            player.Cards.Add(card);

            form.Controls.Add(new PictureBox()
            {
                Name = string.Format("Player_{0}", player.Cards.Count - 1),
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Image,
                Location = new Point(form.Width / 4 + (player.Cards.Count * 40), heightPlayer)
            });
        }

        public void PickCardCroupier(bool isVisible)
        {
            var animator = ImageSpriteGenerator.getInstance();
            int idx = croupier.GetIndex();
            var card = animator.cardsGame[idx];
            card.Visible = isVisible;
            croupier.Cards.Add(card);

            form.Controls.Add(new PictureBox()
            {
                Name = string.Format("Croupier_{0}", croupier.Cards.Count - 1),
                Width = card.Image.Width,
                Height = card.Image.Height,
                Image = card.Visible ? card.Image : animator.hideCard.Image,
                Location = new Point(form.Width / 4 + (croupier.Cards.Count * 40), heightCroupier)
            });
        }

        private void BackCard(MainForm form)
        {
            foreach (var c in form.Controls)
            {
                if (c is PictureBox && (c as PictureBox).Name.Equals("Croupier_1"))
                    (c as PictureBox).Image = croupier.Cards[1].Image;
            }
        }

        public void ResetCards()
        {
            player.Cards.Clear();
            croupier.Reset();
        }
    }
}
