using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class Chimpanzee : Animals, ITrainable
    {
        private Dictionary<string, string> _behavior = new Dictionary<string, string>();  
        public Dictionary<string, string> Behavior { get; set; }

        public Chimpanzee(string species, string treat) : base(species, treat)
        {

            Console.WriteLine($"{Species} {treat}");
        }

        public string Perform(string signal)
        {
            string placeHolder = "" ;

            return placeHolder; 
        }

        public string Train(string signal, string behavoir)
        {
            //Add the behavior the behavior dictionary 
            _behavior.Add(signal, behavoir);

            foreach (KeyValuePair<string, string> behav in _behavior)
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
            string noise = "Hoo Hoo Haa Haa";

            //Return the sound 
            return noise;
        }


    }
}
