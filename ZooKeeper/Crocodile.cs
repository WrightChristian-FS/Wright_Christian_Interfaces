using System;
namespace ZooKeeper
{
    public class Crocodile : Animals
    {
        public Crocodile(string species, string treat) : base(species, treat)
        {
        }

        public override string MakeNoise()
        {
            //String to hold sound
            string noise = "moo";


            //Return the sound 
            return noise;
        }

    }
}
