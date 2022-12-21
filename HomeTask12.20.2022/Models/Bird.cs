using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12._20._2022.Models
{
    internal class Bird:Animal
    {
        public string Type { get; set; }

        public override void Sound()
        {
            Console.WriteLine("Bird Sound");
        }
        public override void Eating()
        {
            Console.WriteLine("Bird Eating");
        }
    }

}
