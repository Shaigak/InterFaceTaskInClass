using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12._20._2022.Models
{
    internal  abstract class Animal
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string color  { get; set; }


        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

        public abstract void Eating();
    }

    interface IAnimal
    {
       
    }

}
