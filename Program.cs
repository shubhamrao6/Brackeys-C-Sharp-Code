using System;
using System.Collections.Generic;

namespace Brackeys
{
    
    class Wizard
    {
        public string name;
        public string favouriteSpell;
        // private int spellSlots;
        // private float experience;
        public int spellSlots;
        public float experience;

        public static int Count;

        public Wizard(string _name, string _favouriteSpell) 
        {
            name = _name;
            favouriteSpell = _favouriteSpell;
            spellSlots = 2;
            experience = 0.0f;

            Count++;
        }

        public void CastSpell() {
            if (spellSlots > 0) {
                Console.WriteLine(name + " casts " + favouriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }

        public void Meditate() {
            Console.WriteLine(name + " meditates to regain spell slots.");
            spellSlots += 2;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            // wizard01.name = "Parry Hopper";
            // wizard01.favouriteSpell = "Unexpexto Patronum";
            // wizard01.spellSlots = 2;
            // wizard01.experience = 0f;

            Wizard wizard02 = new Wizard("Shubham Dumbledore", "Kavada Adabra");

            Console.WriteLine("Number of Wizards: " + Wizard.Count);
            
            Console.WriteLine("Name: " + wizard02.name);
            Console.WriteLine("Spell Slots: " + wizard02.spellSlots);
            Console.WriteLine("Experience: " + wizard02.experience);

            wizard02.Meditate();
            wizard02.Meditate();
            wizard02.Meditate();
            wizard02.Meditate();
            wizard02.Meditate();
            wizard02.Meditate();
            wizard02.Meditate();

            wizard02.CastSpell();
            wizard02.CastSpell();
            wizard02.CastSpell();

            Console.WriteLine("Name: " + wizard02.name);
            Console.WriteLine("Spell Slots: " + wizard02.spellSlots);
            Console.WriteLine("Experience: " + wizard02.experience);

            Console.WriteLine("#------------------#---------------#");

            Console.WriteLine("Name: " + wizard01.name);
            Console.WriteLine("Spell Slots: " + wizard01.spellSlots);
            Console.WriteLine("Experience: " + wizard01.experience);
            
            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            wizard01.Meditate();
            
            wizard01.CastSpell();
            wizard01.CastSpell();

            Console.WriteLine("Name: " + wizard01.name);
            Console.WriteLine("Spell Slots: " + wizard01.spellSlots);
            Console.WriteLine("Experience: " + wizard01.experience);

            // Wait before closing
            Console.ReadKey();
        }

        static void WordCounter(string[] args) 
        {
            string example = "I hate programming.";
            int wordCount;
            wordCount = example.Split(' ').Length;
            Console.WriteLine(wordCount);
        }

        static void MethodDemo(string[] args) 
        {

            int result = Multiply(3,4);
            
            Console.WriteLine("The result is: " + result);

            if (result % 2 == 0) {
                Console.WriteLine("The result is even.");
            } else {
                Console.WriteLine("The result is odd.");
            }

            // MeetAlien();
            // Console.WriteLine("---------------------");
            // MeetAlien();
        }

        static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }

        static void MeetAlien()
        {
            Random numberGen = new Random();

            string name = "X-"+numberGen.Next(10,99999);
            int age = numberGen.Next(10,5000);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, and I'm an alien."); 
        }

        static void ListDemo(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i=0 ; i<shoppingList.Count; i++) {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("---------------------");

            for (int i=0 ; i<shoppingList.Count; i++) {
                Console.WriteLine(shoppingList[i]);
            }
        }

        static void ArrayDemo(string[] args) 
        {
            string[] movies = new string[4];

            Console.WriteLine("Type in for movies: ");

            for (int i = 0; i < movies.Length; i++) {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine("Here they are alphabetically: ");

            Array.Sort(movies);

            for (int i=0; i < movies.Length; i++) {
                Console.WriteLine(movies[i]);
            }

            // string[] movies = {"The Godfather", "Lord Of The Rings", "Interstellar", "Lunch Box", "Fight Club"};

            // for (int i = 0; i < movies.Length; i++) {
            //     int rank  = i + 1;
            //     Console.WriteLine(rank + ". " + movies[i]);
            // } 
        }

        static void WhileLoopDemo(string[] args)
        {
            Random numberGen = new Random();
            // numberGen.Next(0, 4);

            int roll = 0;
            int attempts = 0;

            Console.WriteLine("Press enter to roll die.");

            while(roll != 6) {
                Console.ReadKey();

                roll = numberGen.Next(1,7);
                Console.WriteLine("You rolled: " + roll);
                attempts ++;
            }

            Console.WriteLine("It took you " + attempts + " to roll six.");
        }

        static void ForLoopDemo(string[] args)
        {
            Console.Write("How many cool numbers do you want?");
            
            int count = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=count; i++) 
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

        }

        static void SwitchDemo(string[] args) 
        {
            Console.Write("Input a number between 1 and 5: ");

            int num = Convert.ToInt32(Console.ReadLine());

            switch(num) {
                case 1: 
                Console.WriteLine("One");
                break;
                case 2: 
                Console.WriteLine("Two");
                break;
                case 3: 
                Console.WriteLine("Three");
                break;
                case 4: 
                Console.WriteLine("Four");
                break;
                case 5: 
                Console.WriteLine("Five");
                break;
                default:
                Console.WriteLine("Default");
                break;
            }

            // Wait before closing
            Console.ReadKey();
        }

        static void Conditional2(string[] args)
        {
            int age;
            int height;

            Console.Write("Please input age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please input height: ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 && height >= 160) { // || for or
                Console.WriteLine("You can enter!");
            } else {
                Console.WriteLine("You do not meet the requirements!");
            }

            // Wait before closing
            Console.ReadKey();
        }

        static void Conditional1(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5) {
                Console.WriteLine("That's not enough money!");
            }
            else if (cash == 5) {
                Console.WriteLine("Here is your ticket!");
            } 
            else {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket and " + change + " dollars in change.");
            }

            // Wait before closing
            Console.ReadKey();
        }

        static void VariablesDemo(string[] args)
        {
            // Console.WriteLine("What is your name?");

            // string userName = Console.ReadLine();

            // Console.WriteLine("Hello " + userName + ", nice to meet you!");

            double num01; // can use int, string, double, float, boolean
            double num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("Input another number: ");
            num02 = Convert.ToDouble(Console.ReadLine());

            double result = num01 * num02;
            Console.WriteLine("The result is " + result);

            // Wait before closing
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }

        static void PrintDemo(string[] args)
        {

            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.WindowHeight = 40;

            // Get a conversation going

            // Console.WriteLine("Hello World! You are a piece of Shit!!!");
            Console.WriteLine("Hello what's your name?");

            Console.ReadLine(); // This works too

            Console.WriteLine("My name is RX-9000. \nI'm sent from the future to destroy humanity.");
            Console.WriteLine("What is your favourite color?");

            Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Cool mine is destruction.");

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }
    }
}
