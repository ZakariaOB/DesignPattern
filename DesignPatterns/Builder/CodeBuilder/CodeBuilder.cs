using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder.CodeBuilder
{
    public class CodeBuilder
    {
        private string _className { get; set; }
        private List<Tuple<string, string>> _propertyList { get; set; }
        public CodeBuilder(string className)
        {
            _className = className;
            _propertyList = new List<Tuple<string, string>>();
        }

        public CodeBuilder AddField(string type, string propertyName)
        {
            _propertyList.Add(Tuple.Create(type, propertyName));
            return this;
        }

        public override string ToString()
        {
            StringBuilder 
        }
    }
}
