/*
 * Christian Wright 
 * 26JUL2021 
 * APA ZooKeeper Application
 * 
 */

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

            Behavior = _behavior;
        }

        public string Perform(string signal)
        {
            //String to return
            string performedTrick = null;

            //Verify that the signal is a trained signal 
            foreach (KeyValuePair<string, string> trick in Behavior)
            {
                if (signal.ToLower() == trick.Key.ToLower())
                {
                    performedTrick = $"\r\nThe dolphin {trick.Value} when you {trick.Key}";
                    break;
                }
                else
                {
                    performedTrick = ($"\r\nSorry {signal} is not a taught signal for a trick!");
                }
            }

            return performedTrick;
        }

        public string Train(string signal, string behavoir)
        {
            //Add the behavior the behavior dictionary 
            _behavior.Add(signal, behavoir);

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
