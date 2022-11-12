using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3
{

    abstract class UserError
    {

        public abstract void UEMessage(string message);

    }


    //class Test : UserErrorDemo
    //{
    //    public Test()
    //    {
    //        Number = 34;
    //        Met();
    //    }

    //    public override void UEMessage(string message)
    //    {
    //        throw new NotImplementedException();

    //    }

    //}



    //abstract class UserErrorDemo
    //{
    //    //Kan ha provata fält
    //    //Kan ha metoder
    //    public void Met()
    //    {

    //    }
    //    //Kan ha properties
    //    public int Number { get; set; }

    //    //Kan ha privata metoder

    //    //Kan ha abstrakta metoder måste implementeras ov subklasser
    //    public abstract void UEMessage(string message);

    //} 

}
