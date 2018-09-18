using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPaternBook
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I am Flying!!");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
