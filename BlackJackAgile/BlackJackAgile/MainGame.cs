﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public class MainGame
    {
        private static Random rnd = new Random();

        public int GeneralBet { get; set; }

        private List<int> indexUsed { get; set; }

        public MainGame() {
            indexUsed = new List<int>();
        }

        public void ResetGame() {
            GeneralBet = 0;
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
