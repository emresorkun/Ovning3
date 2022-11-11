using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class NumericInputError : Test
    {
        
        public override void UEMessage(string message)
        {
            DisplayTestName();
            //return "You tried to use a\r\nnumeric input in a text only field. This fired an error!"
        }
    }
}
