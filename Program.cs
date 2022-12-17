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
                // Init Warrior stats
            }
            else if (FighterType == 2) 
            {
                // init Berserker stats
            }
            else if (FighterType == 3) 
            {
                // init Knight stats
            }
            else if (FighterType == 4)
            {
                // init Cheat stats
            }
            else if (FighterType == 5)
            {
                Console.WriteLine("Which savefile do you want to load? (1, 2 or 3)");
                string whichsavefile = Console.ReadLine();
                if (whichsavefile == "1") 
                {
                    // load every value in the savefile and initialize it.
                    string ATKs = File.ReadLines("C:/Users/RPGGameSaves/savegame1.txt").First();
                    int ATK = Convert.ToInt32(ATKs);
                    string DEFs = File.ReadLines("C:/Users/RPGGameSaves/savegame1.txt").Skip(1).Take(1).First();
                    int DEF = Convert.ToInt32(DEFs);
                }
                else if (whichsavefile == "2") 
                {
                    // load every value in the savefile and initialize it. 
                }
                else if (whichsavefile == "3") 
                {
                    // load every value in the savefile and initialize it.
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid savefile.");
                    Thread.Sleep(2000);
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
            
            
        }

        static void WriteSave(int args)
        {
            // Write Save
            Console.Clear();
            Console.WriteLine("Which save location do you want to write to? (1, 2 or 3)");
        }
    }
}