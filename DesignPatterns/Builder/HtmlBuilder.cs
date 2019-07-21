namespace DesignPatterns.Builder
{
    public class HtmlBuilder
    {
        private readonly string rootName;
        HtmlElement root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.rootName = rootName;
            root.Name = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new HtmlElement(childName, childText);
            root.HtmlElementList.Add(e);
        }

        public void Clear()
        {
            root = new HtmlElement
            {
                Name = rootName
            };
        }

        /// <summary>
        /// To string 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return root.ToString();
        }
    }
}
