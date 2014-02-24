using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            Total = 0;
        }

        public Calculator(int init)
        {
            Total = init;            
        }

        public int Total { get; set; }

        public void Add(int a)
        {
            Total += a;
        }

        public void Reset()
        {
            Total = 0;
        }
    }
}
