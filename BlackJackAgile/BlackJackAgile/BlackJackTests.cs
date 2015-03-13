using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    [TestFixture]
    class BlackJackTest
    {
        Player joueur = new Player();
        MainGame game = new MainGame();

        [Test]
        public void verifyBet()
        {
            int cave = joueur.MyBet;
            Assert.LessOrEqual(game.GeneralBet, cave);
        }

        /*
         * Vérifier la présence de 2 cartes pour le joueur (mélange et distribution)
         * 2 cartes pour le joueur, 2 cartes pour le croupier avec une carte face cachée)
         */

    }
}
