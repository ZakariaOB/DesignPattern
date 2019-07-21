using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {

        public int Area => Height * Width;
        public int Height { get; set; }
        public int Width { get; set; }

        public bool IsSquare()
        {
            return this.Height == this.Width;
        }

        public virtual void Show()
        {
            Console.WriteLine("Show rectangle");
        }
        
        public string AddDevelop1()
        {
            return "Dev 1";
        }

        public string AddDevelop2()
        {
            return "Dev 2";
        }

        public string  AddFix1()
        {
            return "Add fix 1";
        }
    }
}
