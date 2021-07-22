using System;
namespace ZooKeeper
{
    public class Animals
    {

        //Fields
        private int _foodConsumed;
        private string _treat;

        protected static int FoodConsumed { get; set; }

        public string Species { get; set; }
        public string Treat { get; set; }
        


        public Animals(string species, string treat) 
        {
            Species = species;
            _treat = treat;

           
            
        }

        public static void Eat(Animals animal)
        {

            //This method will feed the animals 

            if (animal._foodConsumed > 3)
            {
                Poop(animal);
                animal._foodConsumed = 0; 
            } else
            {
                Console.WriteLine($"\r\nThe {animal.Species} ate a {animal._treat}");
                animal._foodConsumed += 1; 

            }

        }

        public virtual string MakeNoise()
        {
            //String to hold sound
            string noise = "moo";


            //Return the sound 
            return noise; 
        }

        public static void Poop(Animals animal)
        {
            //This should write out to the console that the animal has pooped.

            Console.WriteLine($"\r\nThe {animal.Species} has pooped!");
        }


    }
}
