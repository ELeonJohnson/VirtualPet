using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {


            int usersChoice;
            KomodoDragon myPet = new KomodoDragon("Komodo Dragon", "Ruby", 1000, 1);

            //string[] shoppingList = new string[5];
            //shoppingList[0] = "Deer";
            //shoppingList[1] = "Buffalo";
            //shoppingList[2] = "Pigs";
            //shoppingList[3] = "Smaller Dragons";
            //shoppingList[4] = "Carrion";


            Console.WriteLine("I have a " + myPet.TypeOfPet + " as a pet.");
                Console.WriteLine("Her name is " + myPet.NameOfPet + ".");
                Console.WriteLine("She's " + myPet.AgeOfPet + " yes, " + myPet.AgeOfPet + " years old!");
                Console.WriteLine("How much she weighs you ask?");
                Console.WriteLine("Well, she weighs a ton...literally.");
                Console.WriteLine(myPet.NameOfPet + " clocks in at exactly " + myPet.WeightOfPet + " ton!!!");
                Console.WriteLine("Let's see how close you get with " + myPet.NameOfPet + ".");
               



         do
            {

            Console.WriteLine(myPet.TickTockBored());
            Console.WriteLine(myPet.TickTockHunger());
            Console.WriteLine(myPet.TickTockTiredness());
            Console.WriteLine(myPet.TickTockBonding());
            Console.WriteLine("Type 1 if you would like to check to see if shes hungry.");
            Console.WriteLine("Type 2 if you would like to feed " + myPet.NameOfPet + ".");
            Console.WriteLine("Type 3 if you would like to get some exercise with " + myPet.NameOfPet + ".");
            Console.WriteLine("Type 4 if you would like for " + myPet.NameOfPet + " to get some sleep.");
            Console.WriteLine("Type 5 if you would like to play with " + myPet.NameOfPet + ".");
            Console.WriteLine("Type 6 if you would like to go shopping with " + myPet.NameOfPet + ".");
            Console.WriteLine("Type 7 if you would like to exit.");
            usersChoice = int.Parse(Console.ReadLine());

                
                switch (usersChoice)
                {
                    case 1:
                        Console.WriteLine(myPet.NameOfPet + myPet.RubyHunger());
                        Console.WriteLine(myPet.NameOfPet + "'s Hunger Level Increased By: " + myPet.Hunger);
                        break;

                    case 2:
                        myPet.FeedingRuby();
                        Console.WriteLine("Thank's for feeding Ruby, she eats a lot.");
                        Console.WriteLine("Hunger Level: " + myPet.Hunger);
                        break;

                    case 3:
                        myPet.ExerciseTime();
                        Console.WriteLine(myPet.NameOfPet + " loves working out.");
                        Console.WriteLine("Strength Level: " + myPet.Strength);
                        break;

                    case 4:
                        myPet.SleepTime();
                        Console.WriteLine(myPet.NameOfPet + " feels a little restored.");
                        Console.WriteLine("Tiredness Level: " + myPet.Tiredness);
                        break;
                    case 5:
                        myPet.PlayingTime();
                        Console.WriteLine(myPet.NameOfPet + " is feeling the love.");
                        Console.WriteLine("Bondness Level: " + myPet.Bonding);
                        break;

                    case 6:
                        myPet.ShoppingWithRuby();
                        break;
                }

                  



            } while (usersChoice != 7);

            

            
        }
    }
}
