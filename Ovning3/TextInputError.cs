using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{
    class TextInputError : UserError
    {
        public override void UEMessage(string message)
        {
            Console.WriteLine("“You tried to use a text\r\ninput in a numeric only field. This fired an error!");
        }
    }
}
