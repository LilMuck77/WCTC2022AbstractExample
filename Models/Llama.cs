using System;

namespace AbstractExample.Models
{

    public class Llama : Animal
    {
        public LLama(string name)
        {
            Name = name;
        }
        public Llama()
        {
            Name = "Darby";
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"{Name} says AAAAAHHH");
        }

        public override void Sleep()
        {
            Console.WriteLine("haaaaa heeeeeew haaaaa heeeeww.");
        }


    }

}