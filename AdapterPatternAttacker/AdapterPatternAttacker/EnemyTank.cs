using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternAttacker
{
    class EnemyTank : IEnemyAttacker
    {
        Random rnd = new Random();

        public void AssignDriver(string driverName)
        {
            Console.WriteLine($"{driverName} is driving the tank");
        }

        public void DriveForward()
        {
            int movement = rnd.Next(1, 5);
            Console.WriteLine($" Enemy Tank moves {movement} spaces");
        }

        public void FireWeapon()
        {
            int attackDamage = rnd.Next(1, 10);
            Console.WriteLine($"Enemy Tank does {attackDamage} Damage");
        }
    }
}
