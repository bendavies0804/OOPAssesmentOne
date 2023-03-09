﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{

    class Card
    {

        /*
        //Base for the Card class.


        //Value: numbers 1 - 13
        
        public enum Value 
        { 
            Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King 
        };
        //Suit: numbers 1 - 4
        public enum Suit 
        { 
            Spades, 
            Hearts, 
            Diamonds, 
            Clubs 
        };

        
        //The 'set' methods for these properties could have some validation
   

        public Card(Value Value, Suit Suit)
        {
            Value = value;
            Suit = suit; 

        }
        */

        public int Value { get; set; }
        public string Suit { get; set; }
        public Card(int val)
        {
            // Generating the corresponding cards to values and suits
            Value = (val % 13) + 1;
            if (val / 13 == 0)
            {
                Suit = "Diamonds";
            }
            else if (val / 13 == 1)
            {
                Suit = "Clubs";
            }
            else if (val / 13 == 2)
            {
                Suit = "Hearts";
            }
            else
            {
                Suit = "Spades";
            }
        }
        // Custom added method to display Ace, Jack, Queen or King as well as making the numbers in the same format
        public string Display()
        {
            if (Value == 1)
            {
                return "Ace of " + Suit;
            }
            else if (Value == 11)
            {
                return "Jack of " + Suit;
            }
            else if (Value == 12)
            {
                return "Queen of " + Suit;
            }
            else if (Value == 13)
            {
                return "King of " + Suit;
            }
            else
            {
                return Value + " of " + Suit;
            }
        }
    }
}
