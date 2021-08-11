
using System;

namespace Memento
{
    static class AppMain
    {
        static void Main()
        {
            Originator originator = new("Azaska priem!");
            Caretaker caretaker = new(originator);

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            caretaker.Backup();
            originator.DoSomething();

            Console.WriteLine();
            caretaker.ShowHistory();

            Console.WriteLine("\nClient: Now, let's rollback!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: Once more!\n");
            caretaker.Undo();

            Console.WriteLine("\n\nClient: And in the last!\n");
            caretaker.Undo();

            Console.Write('\n');
            _ = Console.ReadKey(true);
        }
    }
}

