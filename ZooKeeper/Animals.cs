using System;
namespace ZooKeeper
{
    public class Animals
    {

        //Fields
        private int _foodConsumed;
        private string _treat; 

        public string Species { get; set; }
        public int FoodConsumed { get; set; }


        public Animals(string species, string treat) 
        {
            Species = species;
            _treat = treat; 
        }

        public static void Eat()
        {
            //If animal eats more than for time trigger Poop()

            //It should return a string describing how the animal ate the
            //food that looks like this: "The dolphin ate a herring”
        }

        public virtual string MakeNoise()
        {
            //String to hold sound
            string noise = "moo";


            //Return the sound 
            return noise; 
        }

        public static void Poop()
        {
            //This should write out to the console that the animal has pooped.
            //For ex: "The dolphin pooped!”
        }


    }
}
