using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    
    public class Calculator
    {
        private int a, b;
        public Calculator(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int execute(string pheptoan)
        {
            int kq = 0;
            switch (pheptoan)
            {
                case "+":
                    kq = this.a + this.b;
                    break;
                case "-":
                    kq = this.a - this.b;
                    break;
                case "*":
                    kq = this.a * this.b;
                    break;
                case "/":
                    if (b == 0)
                        new DivideByZeroException("Loi so bi chia");
                    kq = this.a / this.b;
                    break;
            }
            return kq;
        }
    }
}
