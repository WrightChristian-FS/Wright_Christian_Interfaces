/*
 * Christian Wright 
 * 26JUL2021 
 * APA ZooKeeper Application
 * 
 */

using System;
namespace ZooKeeper
{
    public class Camel : Animals
    {
        public Camel(string species, string treat) : base(species, treat)
        {
        }

        public override string MakeNoise()
        {
            //String to hold sound
            string noise = "MOOOOO";


            //Return the sound 
            return noise;
        }

     
    }
}
