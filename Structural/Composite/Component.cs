
using System;

namespace Composite
{
    abstract class Component
    {
        public virtual void Add(Component component) => throw new NotImplementedException();
        public virtual void Remove(Component component) => throw new NotImplementedException();
        public virtual bool IsComposite => true;
        public abstract string Operation();
    }
}

