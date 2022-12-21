using HomeTask12._20._2022.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12._20._2022
{
    internal class Person :Test, IPerson
    {
        public void GetName()
        {
            Console.WriteLine("Cavid");
        }
    }
}
