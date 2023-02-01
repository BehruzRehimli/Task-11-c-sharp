using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_11_Task.Exaption
{
    public class ProductNotFoundException:Exception
    {
        public ProductNotFoundException():base("\nAxtardiginiz nomrede product yoxdur\n")
        {

        }
    }
}
