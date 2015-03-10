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

        private ImageSpriteGenerator()
        {
            cardsGame = new List<Card>();
        }

        public List<Card> cardsGame
        {
            get;
            set;
        }

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
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    var rectangle = new Rectangle(i * width, j * height, width, height);
                    Bitmap bmpCrop = bmpImage.Clone(rectangle, bmpImage.PixelFormat);
                    cardsGame.Add(new Card(i > 9 ? 10 : i + 1, bmpCrop));
                }
            }
        }
    }
}

