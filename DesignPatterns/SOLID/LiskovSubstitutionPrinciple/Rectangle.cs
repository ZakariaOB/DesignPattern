using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public int Height { get; set; }

        public int Width { get; set; }

        public int Area => Height * Width;

        public virtual void Show()
        {
            Console.WriteLine("Show rectangle");
        }
    }
}
