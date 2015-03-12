using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using BlackJackAgile.Properties;

namespace BlackJackAgile
{
    public class ImageSpriteGenerator
    {
        private static ImageSpriteGenerator INSTANCE = null;

        private const int NB_PAQUET = 6;

        private const int NB_CARTE_WIDTH = 13;

        private const int NB_CARTE_HEIGHT = 4;

        private ImageSpriteGenerator()
        {
            cardsGame = new List<Card>();
        }

        public List<Card> cardsGame
        {
            get;
            set;
        }

        public Card hideCard { get; set; }

        public static ImageSpriteGenerator getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new ImageSpriteGenerator();
            }
            return INSTANCE;
        }

        public void Load()
        {
            Bitmap bmpImage = new Bitmap(Resources.cards);
            var height = bmpImage.Height / 5;
            var width = bmpImage.Width / 13;
            int i, j;
            for (i = 0; i < NB_CARTE_HEIGHT; i++)
            {
                for (j = 0; j < NB_CARTE_WIDTH; j++)
                {

                    cardsGame.Add(GetCard(i, j, width, height, bmpImage));
                }
            }

            // Dernière carte de l'image est la carte retournée
            hideCard = GetCard(NB_CARTE_HEIGHT, 0, width, height, bmpImage);
        }

        private Card GetCard(int i, int j, int width, int height, Bitmap bmpImage)
        {
            var rectangle = new Rectangle(j * width, i * height, width, height);
            Bitmap bmpCrop = bmpImage.Clone(rectangle, bmpImage.PixelFormat);
            return new Card(j > 9 ? 10 : j + 1, bmpCrop);
        }
    }
}

