using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class KomodoDragon
    {

        //Fields
        private string typeOfPet;
        private string nameOfPet;
        private int ageOfPet;
        private int weightOfPet;
        private int hunger;
        private int strength;
        private int tiredness;
        private int bored;
        private int bonding;
        private bool feeding;
        private bool exercise;
        private bool sleep;
        private bool playTime;
        private bool shopping;



        //Properties

        public string TypeOfPet
        {
            get { return this.typeOfPet; }
            set { this.typeOfPet = value; }
        }

        public string NameOfPet
        {
            get { return this.nameOfPet; }
            set { this.nameOfPet = "Ruby"; }
        }

        public int AgeOfPet
        {
            get { return this.ageOfPet; }
            set { this.ageOfPet = 1000; }

        }
        public int WeightOfPet
        {
            get { return this.weightOfPet; }
            set { this.weightOfPet = 1; }
        }

        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }

        }

        public int Strength
        {
            get { return this.strength; }
            set { this.strength = value; }
        }

        public int Tiredness
        {
            get { return this.tiredness; }
            set { this.tiredness = value; }
        }

        public int Bored
        {
            get { return this.bored; }
            set { this.bored = value; }
        }

        public bool Sleep
        {
            get { return this.sleep; }
            set { this.sleep = value; }
        }

        public bool Feeding
        {
            get { return this.feeding; }
            set { this.feeding = value; }
        }

        public bool Exercise
        {
            get { return this.exercise; }
            set { this.exercise = value; }
        }

        public bool PlayTime
        {
            get { return this.playTime; }
            set { this.playTime = value; }
        }

        public bool ShoppingWithPet
        {
            get { return this.shopping; }
            set { this.shopping = value; }
        }
        
        public int Bonding
        {
            get { return this.bonding; }
            set { this.bonding = value; }
        }


       

        


        //Constructors 

        public KomodoDragon(string typeOfPet, string nameOfPet, int ageOfPet, int weightOfPet)
        {
            this.typeOfPet = typeOfPet;
            this.nameOfPet = nameOfPet;
            this.ageOfPet = ageOfPet;
            this.weightOfPet = weightOfPet;
        }


        //Method 

      public string TickTockBored()
        {
            Console.WriteLine(nameOfPet + " The Dragon:");
            bored += 10;
            Console.WriteLine("Bored Level Increased By: 10 Overtime");
            return nameOfPet + "'s Bored Level: " + bored;
        }

      public  string TickTockHunger()
        {
            hunger += 10;
            Console.WriteLine("Hunger Level Increased By: 10 Overtime");
            return nameOfPet + "'s Hunger Level: " + hunger;
        }


      public string TickTockTiredness()
        {
            tiredness += 10;
            Console.WriteLine("Tiredness Level Increased By: 10 Overtime");
            return nameOfPet + "'s Tiredness Level: " + tiredness;
        }

      public string TickTockBonding()
        {
            bonding -= 10;
            Console.WriteLine("Bonding Level Decreased By: 10 Overtime");
            return nameOfPet + "'s Bonding Level: " + bonding;
        }

    public string RubyHunger()
        {
            
            if(hunger == 0)
            {

                strength += 10;
                Console.WriteLine("Strength Level Increased By: 10");
                tiredness -= 10;
                Console.WriteLine("Tiredness Level Decreased By: 10");

                return " is full.";

            }
            else if (hunger < 100)
            {
                
                strength -= 10;
                Console.WriteLine("Strength Level Decreased By: 10");
                tiredness += 15;
                Console.WriteLine("Tiredness Level Increased By: 15");
                return " is hungry.";
            }
  
            else if (hunger > 0)
            {
                tiredness += 5;
                Console.WriteLine("Tiredness Level Increased By: 5");
                strength += 5;
                Console.WriteLine("Strength Level Increased By: 5");
                return " is starving!";
            }

            else
            {
                return "";
            }
        }

        public void SleepTime()
        {
            if (sleep)
            {
                tiredness += 10;
                Console.WriteLine("Tiredness Level Increased By: 10");

            }
            else
            {
                tiredness -= 100;
                Console.WriteLine("Tiredness Level Decreased By: 100");

                bored -= 20;
                Console.WriteLine("Bored Level Decreased By: 20");

            }
        }

        public void PlayingTime()
        {
            if (playTime)
            {
                bored += 10;
                Console.WriteLine("Bored Level Increased By: 10");

                bonding -= 25;
                Console.WriteLine("Bonding Level Decreased By: 25");

            }
            else
            {
                bored -= 20;
                Console.WriteLine("Bored Level Decreased By: 20");

                bonding += 40;
                Console.WriteLine("Bonding Level Increased By: 40");

            }
        }

        public int FeedingRuby()
        {
            feeding = true;
            hunger -= 20;
            Console.WriteLine("Hunger Level Decreased By: 20");

            strength += 5;
            Console.WriteLine("Strength Level Increased By: 5");

            tiredness += 5;
            Console.WriteLine("Tiredness Level Increased By: 5");

            bonding += 5;
            Console.WriteLine("Bonding Level Increased By: 5");

            return hunger;
        }

        public void ExerciseTime()
        {
         
            if(exercise == true)
            {
                strength -= 5;
                Console.WriteLine("Strength Level Decreased By: 5");

                bonding -= 5;
                Console.WriteLine("Bonding Level Decreased By: 5");

                bored += 10;
                Console.WriteLine("Bored Level Increased By: 10");

            }
            else
            {

                strength += 50;
                Console.WriteLine("Strength Level Increased By: 50");
                tiredness += 10;
                Console.WriteLine("Tiredness Level Increased By: 10");
                bonding += 5;
                Console.WriteLine("Bond Level Increased By: 5");
                bored -= 20;
                Console.WriteLine("Bored Level Decreased By: 20");


            }
        }

        public void ShoppingWithRuby()
        {

            bonding += 5;
            Console.WriteLine("Bond Level Increased By: 5");
            tiredness += 5;
            Console.WriteLine("Tiredness Level Increased By: 5");
            bored -= 5;
            Console.WriteLine("Bored Level Decreased By: 5");

            shopping = true;
                string[] shoppingList = new string[5];
                shoppingList[0] = "Deers";
                shoppingList[1] = "Buffalos";
                shoppingList[2] = "Pigs";
                shoppingList[3] = "Smaller Dragons";
                shoppingList[4] = "Carrions";

            for (int i = 4; i < shoppingList.Length; i++)
            {
                Console.WriteLine("You Bought: {0}, {1}, {2}, {3}, {4}", shoppingList[0], shoppingList[1], shoppingList[2], shoppingList[3], shoppingList[4]);
            }

              
               
          
        }


    
       

       
        
         
       

       
        

    
    }
}
