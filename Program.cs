namespace ds_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр Quadcopter
            Quadcopter quadcopter = new Quadcopter();
            IFlyingRobot flyingRobot = new Quadcopter();
            IRobot simpleRobot = new Quadcopter();

            // Вызываем методы и выводим информацию
            Console.WriteLine(quadcopter.GetInfo());
            Console.WriteLine(simpleRobot.GetRobotType());
            Console.WriteLine("Components: " + string.Join(", ", quadcopter.GetComponents()));
            quadcopter.Charge();
            Console.WriteLine(flyingRobot.GetRobotType());
        }
    }
}