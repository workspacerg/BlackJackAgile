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

        private State? finalState;

        public MainForm form { get; set; }

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
            if (!isLaunched)
            {
                timer.Stop();
                return;
            }
            PickCardCroupier(true);
            form.MAJ();
            if (!Analyze())
                MakeResults();
        }

        public Game()
        {
            player = new Player();
            croupier = new MainGame();
            currentBet = 0;
        }

        public void DoBetOrUnbet(MouseEventArgs e, int value)
        {
            if (isLaunched)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (player.MyBet < value)
                {
                    form.label_Main.Text = String.Format("Vous n'avez pas assez d'argent pour miser {0}€", value);
                    return;
                }
                player.MyBet -= value;
                currentBet += value;
            }
            else
            {
                if (currentBet < value)
                {
                    form.label_Main.Text = String.Format("Vous ne pouvez pas récupérer {0}€", value);
                    return;
                }
                player.MyBet += value;
                currentBet -= value;
            }
        }

        public void Double()
        {
            player.MyBet -= currentBet;
            currentBet *= 2;
        }

        public void Reset()
        {
            player.Reset();
            croupier.Reset();
            currentBet = 0;
        }

        // Fonction quand le joueur dis je reste ou est à 21 (le croupier fait son taff)
        public void LaunchEndGame()
        {
            BackCard(form);
            form.MAJ();
            if (Analyze())
                timer.Start();
            else
                MakeResults();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns> Booléen indiquant si la partie continue ou pas</returns>
        private bool Analyze()
        {
            var ptsCroup = croupier.GetPoints();
            var ptsPlayer = player.GetPoints();
            if (ptsCroup > 21)
            {
                finalState = State.WIN;
                return false;
            }
            else
            {
                if (ptsCroup > 16)
                    return DoStateHigherSixteen();
                else
                    return DoStateUnderOrEqualSixteen();
            }
        }

        private bool DoStateHigherSixteen()
        {
            var ptsCroup = croupier.GetPoints();
            var ptsPlayer = player.GetPoints();
            if (ptsCroup > ptsPlayer)
                finalState = State.LOSE;
            else if (ptsCroup == ptsPlayer)
                finalState = State.DEUCE;
            else
                finalState = State.WIN;

            return false;
        }

        private bool DoStateUnderOrEqualSixteen()
        {
            var ptsCroup = croupier.GetPoints();
            var ptsPlayer = player.GetPoints();
            if (ptsCroup <= ptsPlayer)
                return true;
            finalState = State.LOSE;
            return false;
        }

        public void PickCardPlayer()
        {
            var animator = ImageSpriteGenerator.getInstance();
            int idx = croupier.GetIndex();
            var card = animator.cardsGame[idx];
            card.Visible = true;
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
            croupier.Cards[1].Visible = true;
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
            currentBet = 0;
        }

        public void MakeResults()
        {
            if (!finalState.HasValue)
                return;
            isLaunched = false;
            if (finalState.Equals(State.WIN))
            {
                form.label_Main.Text = "Vous avez gagné !";
                player.MyBet += currentBet * 2;
            }
            else if (finalState.Equals(State.DEUCE))
            {
                form.label_Main.Text = "Vous êtes à égalité, récuperez votre mise.";
                player.MyBet += currentBet;
            }
            else
               form.label_Main.Text = "Vous avez perdu ...";

            currentBet = 0;
            timer.Stop();
            form.button_continue.Visible = true;
        }
    }
}
