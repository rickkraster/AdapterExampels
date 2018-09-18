using System;

namespace AdapterPaternBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var duck = new MallardDuck();

            var turkey = new WildTurkey();
            var turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("turkey:");

            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\n\nturkeyadapter");
            TestDuck(turkeyAdapter);

            Console.WriteLine("\n\nduck");
            TestDuck(duck);

            Console.ReadKey();
        }
        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
