using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        public override void Show()
        {
            Console.WriteLine("Show square");
        }
    }
}
