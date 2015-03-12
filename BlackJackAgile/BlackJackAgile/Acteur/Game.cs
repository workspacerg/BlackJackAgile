using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BlackJackAgile
{
    public class Game
    {

        public int currentBet { get; set; }

        public Player player { get; set; }

        public MainGame croupier { get; set; }

        public bool isLaunched { get; set; }

        public Game() {
            player = new Player();
            croupier = new MainGame();
            currentBet = 0;
        }

        public void DoBetOrUnbet(MouseEventArgs e, int value) {
            int tempPlayerBet = player.MyBet;
            if (isLaunched)
                return;
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
            if (pts > 21) {
                MessageBox.Show(string.Format("Vous êtes à {0}. Vous avez perdu !",pts));
                return StatePick.LOSE;
            }
            if (pts == 21) {
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
            
        }

        public void ResetCards()
        {
            player.Cards.Clear();
            croupier.Reset();
        }
    }
}
