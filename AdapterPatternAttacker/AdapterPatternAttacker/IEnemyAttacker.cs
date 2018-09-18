using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternAttacker
{
    interface IEnemyAttacker
    {
        void FireWeapon();
        void DriveForward();
        void AssignDriver(string driverName);
    }
}
