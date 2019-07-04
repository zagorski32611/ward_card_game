﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace cardwar
{
    class Program
    {
        //Deck deck = new Deck();
        Player player = new Player();
        Player computer = new Player();

        Game game = new Game();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.StartGame();            
        }

        public Player GetNewPlayer(string name)
        {
            Deck deck = new Deck();
            var current_deck = deck.CreateDeck();
            //var current_player = player.CreateNewPlayer(name, current_deck);
            player.Name = name;
            player.Deck = current_deck;
            return player;
        }

        public Player StartComputer()
        {
            Deck deck = new Deck();
            var current_deck = deck.CreateDeck();
            //var current_computer = computer.CreateNewPlayer("Computer", current_deck);
            computer.Name = "Computer";
            computer.Deck = current_deck;
            return computer;
        }

        public Player StartGame()
        {
            var computer = StartComputer();
            var player = GetNewPlayer("Joe");
            
            while(player.Deck.Count > 0 || computer.Deck.Count > 0)
            {
                game.War(player, computer);
            }
            if(player.Deck.Count == 0)
            {
                return computer;
            }
            else
            {
                return player;
            }
        }
    
    }
}
