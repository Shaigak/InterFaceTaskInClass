using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask12._20._2022.Services.Interfaces
{
    internal interface ICalculateService
    {
        void SumNumbers(int num1,int num2);
        int GetSumNumbersFromArray(int[]numbers);
    }
}
