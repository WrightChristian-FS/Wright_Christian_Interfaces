using System;
using System.Collections.Generic; 
namespace ZooKeeper
{
    public class Tiger : Animals , ITrainable
    {
        public Dictionary<string, string> Behavior { get; set; }

        public Tiger(string species, string treat) : base(species, treat)
        {
        }

        public string Perform(string signal)
        {
            string placeHolder = "";

            return placeHolder;
        }

        public string Train(string signal, string behavoir)
        {

            string placeHolder = "";

            return placeHolder;

        }

        public static void Eat()
        {
            //If animal eats more than for time trigger Poop()

            //It should return a string describing how the animal ate the
            //food that looks like this: "The dolphin ate a herring”
        }

        public override string MakeNoise()
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
