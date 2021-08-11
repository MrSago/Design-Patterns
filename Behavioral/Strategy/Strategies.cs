
using System.Collections.Generic;

namespace Strategy
{
    interface IStrategy
    {
        object DoAlgo(object data);
    }

    class ConcreteStrategyA : IStrategy
    {
        public object DoAlgo(object data)
        {
            var list = data as List<string>;
            list.Sort();
            return list;
        }
    }

    class ConcreteStrategyB : IStrategy
    {
        public object DoAlgo(object data)
        {
            var list = data as List<string>;
            list.Sort();
            list.Reverse();
            return list;
        }
    }

}

