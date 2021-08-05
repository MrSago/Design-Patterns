
using System.Collections.Generic;

namespace Composite
{
    class Leaf : Component
    {
        public override bool IsComposite => false;
        public override string Operation()
        {
            return "Leaf";
        }
    }

    class Composite : Component
    {
        protected readonly List<Component> _children = new();
        public override void Add(Component component)
        {
            _children.Add(component);
        }
        public override void Remove(Component component)
        {
            _children.Remove(component);
        }
        public override string Operation()
        {
            int i = 0;
            string result = "Branch(";
            foreach (var it in _children)
            {
                result += it.Operation();
                if (i++ < _children.Count - 1)
                {
                    result += '+';
                }
            }
            return result + ')';
        }
    }
}

