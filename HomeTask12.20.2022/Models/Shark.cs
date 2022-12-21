using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12._20._2022.Models
{
    internal class Shark:Animal
    {
        public int TeethCount { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Shark Sound");
        }
        public override void Eating()
        {
            Console.WriteLine("Shark Eating");
        }

    }
}
