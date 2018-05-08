using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> HtmlElementList = new List<HtmlElement>();
        private const int indentSize = 2;

        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            if (name == null)
                throw new ArgumentNullException(paramName: nameof(name));
            if (text == null)
                throw new ArgumentNullException(paramName: nameof(text));
            Name = name;
            Text = text;
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach(var x in HtmlElementList)
            {
                sb.Append(x.ToStringImpl(indent + 1));
            }

            sb.Append($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
