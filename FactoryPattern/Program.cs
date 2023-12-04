namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tiers does your vehicle have?");
            int wheelCount;
            var answer = int.TryParse(Console.ReadLine(), out wheelCount);
            var final = VehicleFactory.GetVehicle(wheelCount);
            final.Drive();
            

        }
    }
}
