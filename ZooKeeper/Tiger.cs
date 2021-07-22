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

        public override string MakeNoise()
        {
            //String to hold sound
            string noise = "ROAAAAR!!";


            //Return the sound 
            return noise;
        }


    }
}
