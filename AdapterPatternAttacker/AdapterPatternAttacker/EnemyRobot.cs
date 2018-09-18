using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternAttacker
{
    class EnemyRobot
    {
        Random rnd = new Random();

        public void SmashWithHands()
        {
            int attackDamage = rnd.Next(1, 10);
            Console.WriteLine($"Enemy robot does {attackDamage} damage with its hands");
        }

        public void WalkForward()
        {
            int movement = rnd.Next(1, 10);
            Console.WriteLine($"Enemy robot Walks forward {movement} spaces");
        }
        public void ReactToHuman(string driverName)
        {
            Console.WriteLine($"Enemy Robot Tramps on {driverName}");
        }
    }
}
