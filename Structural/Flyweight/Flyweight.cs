
using System;
using Newtonsoft.Json;

namespace Flyweight
{
    class Flyweight
    {
        private readonly Car _sharedState;

        public Flyweight(Car car)
        {
            _sharedState = car;
        }

        public void Operation(Car uniqueState)
        {
            string s = JsonConvert.SerializeObject(_sharedState);
            string u = JsonConvert.SerializeObject(uniqueState);
            Console.WriteLine($"Flyweight: shared {s}\n" +
                              $"           unique {u}");
        }
    }
}

