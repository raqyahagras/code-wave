namespace CODE_WAVE
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("task 1");
            int num1 = 10;
            int num2 = 20;
            int sum=num1+ num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}.");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("task 2");
            double op1 = -1 + 4 * 6;
            double op2 = (35 + 5) % 7;
            double op3 = 14 + -4 * 6 / 11;
            double op4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"the result of -1 + 4 * 6 is {op1}");
            Console.WriteLine($"the result of (35 + 5) % 7 is {op2}");
            Console.WriteLine($"the result of 14 + -4 * 6 / 11 is {op3}");
            Console.WriteLine($"the result of  2 + 15 / 6 * 1 - 7 % 2 is {op4}");
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("task 3");
            int x=10;
            int y = 20;
            int z= 30;
            Console.WriteLine($"x<y && x<z : {x < y && x < z}");
            Console.WriteLine($"z>x && z>y : {z > x && z > y}");
            Console.WriteLine($"(x+y) == z : {(x + y) == z}");
            Console.WriteLine($"y>(x+z) :{y > (x + z)}");
            Console.WriteLine($"(z-y) == x : {(z - y) == x}");





        }
    }
}
