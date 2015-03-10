using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace BlackJackAgile
{
    public class Card
    {
        private int value;

        private Bitmap image;

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public Card(int _value,Bitmap bitmap)
        {
            value = _value;
            image = bitmap;
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
