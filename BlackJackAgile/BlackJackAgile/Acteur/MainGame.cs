using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public class MainGame : Actioner
    {
        private static Random rnd = new Random();

        public int GeneralBet { get; set; }

        private List<int> indexUsed { get; set; }

        public MainGame() : base() {
            indexUsed = new List<int>();
            Cards = new List<Card>();
        }

        public override void Reset() {
            GeneralBet = 0;
            Cards.Clear();
            indexUsed.Clear();
        }

        public int GetIndex() {
            var animator = ImageSpriteGenerator.getInstance();
            int idx = rnd.Next(0, animator.cardsGame.Count);
            while(indexUsed.Contains(idx))
                idx = rnd.Next(0, animator.cardsGame.Count);
            indexUsed.Add(idx);
            return idx;
        }
    }
}
