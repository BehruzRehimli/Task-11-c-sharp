using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_11_Task.Exaption
{
    public class PriceCantBeMinusException:Exception
    {
        public PriceCantBeMinusException() : base("\nQiymet menfi ola bilmez\n")
        {

        }
    }
}
