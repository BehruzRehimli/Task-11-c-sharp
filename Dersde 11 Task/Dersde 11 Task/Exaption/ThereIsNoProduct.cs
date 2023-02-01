using System;
using System.Collections.Generic;
using System.Text;

namespace Dersde_11_Task.Exaption
{
    public class ThereIsNoProductException: Exception
    {
        public ThereIsNoProductException():base("\nHal hazirda hech bir product yoxdur.\n")
        {

        }
    }
}
