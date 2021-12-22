using System;
using System.Collections.Generic;
using System.Text;

namespace Gambler_Simulator
{
    public class Game
    {
        public int stake_amount = 100;
        public int bet_amount = 1;
        public int count=0;
        public int wincount=0;

        public static void Game_play()
        {
            Console.WriteLine("Every Day Gambler Stake of $100");
            Console.WriteLine("Every Game gambler bets of $1");
            Console.ReadKey();
        }
        public void Win_loose()
        {
            while(stake_amount != 0 && count !=100)
            {
                Console.WriteLine("Gambler will bet $1");
                Random random = new Random();
                int bet = random.Next(0, 2);
                if (bet == 1)
                    {
                        Console.WriteLine("You have Won!");
                        stake_amount++;
                    }
                    else
                    {
                        Console.WriteLine("You have Lost!");
                       stake_amount--;
                    }
                    count++;
                }
            }          
        }
    }
