using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackAgile;
using System.Windows.Forms;

namespace BlackJackAgileTest
{
    [TestClass]
    public class UnitTests
    {
        Game game = new Game();
        MainForm form = new MainForm();
        MouseEventArgs evtSourisClicDroit = new MouseEventArgs(MouseButtons.Right, 0, 0, 0, 0);
        MouseEventArgs evtSourisClicGauche = new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0);

        [TestMethod]
        public void verificationMiseInitial()
        {
            int montantMiseInitial = game.currentBet;
            Assert.IsTrue(montantMiseInitial == 0);
        }

        [TestMethod]
        public void verificationLimitationBorneSupMise()
        {
            game.DoBetOrUnbet(evtSourisClicGauche, 201);
            int montantMise = game.currentBet;
            Assert.IsTrue(montantMise == 0);
        }

        [TestMethod]
        public void verificationLimitationBorneInfMise()
        {
            game.DoBetOrUnbet(evtSourisClicDroit, 50);
            int montantMise = game.currentBet;
            Assert.IsTrue(montantMise == 0);
        }

        [TestMethod]
        public void verificationAjoutMise()
        {
            game.DoBetOrUnbet(evtSourisClicGauche, 50);
            int montantMise = game.currentBet;
            Assert.IsTrue(montantMise == 50);
        }

        [TestMethod]
        public void verificationRetraitMise()
        {
            // mise placé à 100
            game.currentBet = 100;

            game.DoBetOrUnbet(evtSourisClicDroit, 50);
            int montantMise = game.currentBet;
            Assert.IsTrue(montantMise == 50);
        }

        [TestMethod]
        public void pasDeDistributionDeCarteSansMise()
        {
            // mise placé à 0
            game.currentBet = 0;
            game.form = new MainForm();
           
            // on clique sur le bouton "Miser"
            game.form.button_bet_Click(null, null);

            Assert.IsTrue(game.player.Cards.Count == 0);
            Assert.IsTrue(game.croupier.Cards.Count == 0);
        }

        [TestMethod]
        public void verificationChargementDesCartes()
        {
            // récupération des cartes
            ImageSpriteGenerator.getInstance().Load();
            Assert.IsTrue(ImageSpriteGenerator.getInstance().cardsGame.Count == 52);

        }

        [TestMethod]
        public void verificationCartesApresMise()
        {

            // mise placé à 50€
            game.currentBet = 50;
            game.form = form;
            form.game = game;

            // on clique sur le bouton "Miser"
            game.form.button_bet_Click(null, null);

            // on vérifie les cartes du croupier et du joueur : 2 cartes chacun
            // et la deuxième carte du croupier caché
            Assert.IsTrue(game.player.Cards.Count == 2);
            Assert.IsTrue(game.croupier.Cards.Count == 2);
            Assert.IsTrue(game.croupier.Cards[1].Visible == false);
        }

        [TestMethod]
        public void verificationComptePointInit()
        {
             // jeu non démarré
            game.isLaunched = false;

        }

    }
}
