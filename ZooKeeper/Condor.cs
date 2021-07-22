using System;
namespace ZooKeeper
{
    public class Condor : Animals
    {
        public Condor(string species, string treat) : base(species, treat)
        {
        }

        public override string MakeNoise()
        {
            //String tohold sound
            string noise = "Skwawwww!";


            //Return the sound 
            return noise;
        }

    }
}
