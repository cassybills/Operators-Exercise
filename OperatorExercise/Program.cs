namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int div = a / b;
            int mod = a % b;



            Console.WriteLine($"{a}/{b} is {div} remainder {mod}");
    
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            var r = 20;
            var pi = Math.PI;
            var AreaOfCircle = CalculateArea(20);

            

            Console.WriteLine($"The area of a circle with a radius of 20 is {AreaOfCircle}");

        }

        public static double CalculateArea(double radius)
        {
            return Math.PI * (radius * radius);



        }
    }
}
