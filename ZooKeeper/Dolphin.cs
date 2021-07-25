using System;
using System.Collections.Generic; 
namespace ZooKeeper
{
    public class Dolphin : Animals , ITrainable
    {
        public Dictionary<string, string> Behavior { get; set; }


        public Dolphin(string species, string treat) : base(species, treat)
        {
        }

        public string Perform(string signal)
        {
            string placeHolder = "";

            return placeHolder;
        }

        public string Train(string signal, string behavoir)
        {
            //Add the behavior the behavior dictionary 
            Behavior.Add(signal, behavoir);

            foreach(KeyValuePair<string, string> behav in Behavior)
            {
                Console.WriteLine($"Key: {behav.Key} | Value: {behav.Value}");
            }

            //Create a string to hold the response and return to the user
            string newBehavior = $"The dolphin will {behavoir} when you {signal}";
            return newBehavior;
        }

        public override string MakeNoise()
        {
            //String to hold sound
            string noise = "Squueeal";
               


            //Return the sound 
            return noise;
        }

    }
}
