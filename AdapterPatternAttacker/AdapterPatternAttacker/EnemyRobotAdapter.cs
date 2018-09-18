using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPatternAttacker
{
    class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot theRobot)
        {
            this.theRobot = theRobot;
        }
        public void AssignDriver(string driverName)
        {
            theRobot.ReactToHuman(driverName);
        }

        public void DriveForward()
        {
            theRobot.WalkForward();
        }

        public void FireWeapon()
        {
            theRobot.SmashWithHands();
        }
    }
}
