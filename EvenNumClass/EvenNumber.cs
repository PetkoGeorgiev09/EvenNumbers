using System;
using System.Collections.Generic;
using System.Text;

namespace EvenNumClass
{
    internal class EvenNumber
    {
        private int num;

        public EvenNumber(int num)
        {
            this.num = num;
        }

        public int Num { get { return num; } set { num = value; } }

    }
}
