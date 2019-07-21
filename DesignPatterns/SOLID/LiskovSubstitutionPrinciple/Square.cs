﻿using System;
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

		public string AddRepo1_2()
        {
            return "repo 12";
        }
        
        public string AddRepo1()
        {
            return "repo 1";
        }

        public string AddRepo2_2()
        {
            return "repo 22";
        }

        
        public string AddRepo2()
        {
            return "repo 2";
        }

    }
}
