using System;
using System.Collections.Generic;

namespace ZooKeeper
{
    public class Chimpanzee : Animals, ITrainable
    {

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

            string placeHolder = "";

            return placeHolder;

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
