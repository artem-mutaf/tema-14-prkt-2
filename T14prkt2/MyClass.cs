using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T14prkt2
{
    class MyClass
    {
        double value1, value2;
        public static int count;
        public MyClass(double value1,double value2)
        {
            this.value1 = value1;
            this.value2 = value2;
            count++;
        }
        public MyClass()
        {
            value1 = 2.0;
            value2 = 2.0;
            count++;
        }
        static MyClass()
        {
            count = 0;
        }
        public double Value1
        {
            get { return value1; }
            set { value1 = value; }
        }
        public double Value2
        {
            get { return value2; }
            set { value2 = value; }
        }
        public override string ToString()
        {
            return $"{value1}\t{value2}\n{count}";
        }

    }
}
