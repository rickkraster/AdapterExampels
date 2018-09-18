using System;

namespace AdapterPatternAttacker
{
    class Program
    {
        static void Main(string[] args)
        {
            var tank = new EnemyTank();
            var robot = new EnemyRobot();
            var robotAdapter = new EnemyRobotAdapter(robot);

            string driver = "Frank";

            Console.WriteLine("The robot");

            robot.ReactToHuman(driver);
            robot.SmashWithHands();
            robot.WalkForward();

            Console.WriteLine("\nTank");
            Controlls(tank, driver);

            Console.WriteLine("\nRobotAdapter");
            Controlls(robotAdapter, driver);


            Console.ReadKey();
        }
        static void Controlls(IEnemyAttacker tank, string driver)
        {
            tank.AssignDriver(driver);
            tank.DriveForward();
            tank.FireWeapon();
        }
    }
}
