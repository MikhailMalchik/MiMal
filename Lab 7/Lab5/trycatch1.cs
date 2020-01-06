using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6
{
    class trycatch1 : DivideByZeroException
    {
        public trycatch1 (string message): base(message)
        {

        }
    }
}
