
using System.Collections.Generic;

namespace Builder
{
    class Product
    {
        private readonly List<object> parts = new();
        public void Add(string part)
        {
            parts.Add(part);
        }
        public string GetParts()
        {
            string str = string.Empty;
            foreach (var i in parts)
            {
                str += i + ", ";
            }
            str = str.Remove(str.Length - 2);
            return $"Product parts: {str}\n";
        }
    }
}

