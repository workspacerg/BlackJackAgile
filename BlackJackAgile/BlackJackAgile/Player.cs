using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackAgile
{
    public class Player
    {
        public List<Card> MyCards { get; set; }

        public int MyBet
        {
            get;
            set;
        }

        public Player()
            : base()
        {
            MyCards = new List<Card>();
            MyBet = 200;
        }
        
        public int getPtsPlayer(){
        	int currentPts = 0;
        	int nbAs = 0;
        	
        	foreach(Card card in MyCards)
        	{
        		if(card.Value != 1)
        			currentPts += card.Value;
        		else
        			nbAs++;
        	}
        	
        	while(nbAs > 0)
        	{
        		if(currentPts+11 >21)
        			currentPts++;
        		else
        			currentPts+=11;
        		
        		nbAs --;
        	}
        	
        	return currentPts;
        }
    }
}
