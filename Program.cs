using System;
using System.Reflection.Metadata;
using System.Linq;

namespace RPG
{
    class Program
    {
        static void Main()
        {
            //Main Menu
            Console.Clear();
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load saved game");
            Console.WriteLine("3. Exit");
            string choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                // Go to Fighter Select
            }
            else if (choice1 == "2")
            {
                // Read save game
                GameInit(5);
            }
            else if (choice1 == "3") 
            {
                // Exit
                System.Environment.Exit(0);
            }
            else if (choice1 == "69")
            {
                // 69
                Console.Clear();
                Console.WriteLine("Hahaha so funny " + choice1);
                Thread.Sleep(2000);
                throw new Exception(choice1 + " Wow. so funny");
            }
            else
            {
                // Wrong Input
                Thread.Sleep(1000);
                Main();
            }
            
            // Fighter Select
            
            Console.WriteLine("Choose your fighter!");
            Console.WriteLine("1.Warrior, 2.Berserker, 3.Knight");
            string fighter = Console.ReadLine();
            switch (fighter)
            {
                // Normal Fighters
                case "1":
                    GameInit(1);
                    break;
                case "2":
                    GameInit(2);
                    break;
                case "3":
                    GameInit(3);
                    break;
                // Cheat
                case "14235":
                    GameInit(4);
                    break;
                // Wrong Input
                default:
                    Console.WriteLine("Wrong input");
                    Thread.Sleep(2000);
                    throw new Exception("Umm, yeah i actually don't know how to code this");
            }
        }
        
        static void GameInit(int FighterType)
        {
            if (FighterType == 1)
            {
                // tell game it's warrior time
                game(1);
            }
            else if (FighterType == 2) 
            {
                // tell game it's berserker time
                game(2);
            }
            else if (FighterType == 3) 
            {
                // tell game it's knight time
                game(3);
            }
            else if (FighterType == 4)
            {
                // tell game the player is a filthy cheater
                game(4);
            }
            else if (FighterType == 5)
            {
                Console.WriteLine("Are you sure you want to load a save (y or n)?");
                string areyousure = Console.ReadLine();
                if (areyousure == "y")
                {
                    game(5);
                }
                else if (areyousure == "n")
                {
                    Main();
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    Thread.Sleep(1000);
                    GameInit(5);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid fighter.");
                Thread.Sleep(2000);
                Main();
            }
            
            static void game(int FighterType)
            {
                if (FighterType == 5)
                {
                    Console.WriteLine("Which savefile do you want to load? (1, 2 or 3)");
                    string whichsavefile = Console.ReadLine();
                    if (whichsavefile == "1")
                    {
                        // load every value in the savefile and initialize it.
                        string FighterTypeS = File.ReadLines("C:/Users/RPGGameSaves").First();
                        int FighterTypeLoSa = Convert.ToInt32(FighterTypeS);
                        string SwordSlotS = File.ReadLines("C:/Users/RPGGameSaves").Skip(1).Take(1).First();
                        int SwordSlot = Convert.ToInt32(FighterTypeS);
                        string ShieldSlotS = File.ReadLines("C:/Users/RPGGameSaves").Skip(2).Take(1).First();
                        int ShieldSlot = Convert.ToInt32(ShieldSlotS);
                        string InvSlot0S = File.ReadLines("C:/Users/RPGGameSaves").Skip(3).Take(1).First();
                        int InvSlot0 = Convert.ToInt32(InvSlot0S);
                        string InvSlot1S = File.ReadLines("C:/Users/RPGGameSaves").Skip(4).Take(1).First();
                        int InvSlot1 = Convert.ToInt32(InvSlot1S);
                        string InvSlot2S = File.ReadLines("C:/Users/RPGGameSaves").Skip(5).Take(1).First();
                        int InvSlot2 = Convert.ToInt32(InvSlot2S);
                        string EXPS = File.ReadLines("C:/Users/RPGGameSaves").Skip(6).Take(1).First();
                        int EXP = Convert.ToInt32(EXPS);
                        string LVLS = File.ReadLines("C:/Users/RPGGameSaves").Skip(7).Take(1).First();
                        int LVL = Convert.ToInt32(LVLS);
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Invalid savefile.");
                        Thread.Sleep(2000);
                        GameInit(5);
                    }
                }
                else if (FighterType == 1)
                {
                    // Finally init Warrior stats
                }
                else if (FighterType == 2) 
                {
                    // Finally init Berserker stats
                }
                else if (FighterType == 3) 
                { 
                    // Finally init Knight stats
                }
                else if (FighterType == 4) 
                { 
                    // Finally init Cheat stats
                }
                int TurnTimer = 0;
                bool DoTurnTimerTick = false;
                while (TurnTimer == 20)
                {
                    if (DoTurnTimerTick = true) 
                    {
                        // Add 1 to the turn timer and then continue to the game
                        TurnTimer += 1;
                    }
                    if (DoTurnTimerTick = false) 
                    { 
                        // do nothing and continue to the game
                    }
                    // The game
                }
            }
        }
    }
}