using System;
using System.Threading.Tasks;

namespace CSharpRefresher
{
    class MainClass
    {
        static Calculator calculator = new Calculator();
        static void Main(string[] args)
        {
            Start();
        }

        public static async void Start()
        {
            Console.WriteLine("Please enter two numbers.");
            float number1 = float.Parse(Console.ReadLine());
            float number2 = float.Parse(Console.ReadLine());

            DetermineOption(number1, number2);

            var something = ConnectToInternet(); // similar to auto in c++

            // do something else
            // do a lot of things

            var value = await something;

            //use the value
            Console.WriteLine(value);
        }
        
     

        public static void DetermineOption(float n1, float n2)
        {
            bool isLooping = true;
            string resume = null;

            do
            {
                Console.WriteLine("Please make a selection\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide\n5.-Exit Program");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:                        
                        Console.WriteLine("Addition: " + calculator.Add(n1, n2));
                        Console.WriteLine("Continue? Please type y or n.");
                        resume = Console.ReadLine();

                        if (resume == "y")
                        {
                           isLooping = true;
                        }
                        else if (resume == "n")
                        {
                            isLooping = false;
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid selection!");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Subtraction: " + calculator.Subtract(n1, n2));
                        Console.WriteLine("Continue? Please type y or n.");
                        resume = Console.ReadLine();

                        if (resume == "y")
                        {
                            isLooping = true;
                        }
                        else if (resume == "n")
                        {
                            isLooping = false;
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid selection!");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Multiplication: " + calculator.Multiply(n1, n2));
                        Console.WriteLine("Continue? Please type y or n.");
                        resume = Console.ReadLine();

                        if (resume == "y")
                        {
                            isLooping = true;
                        }
                        else if (resume == "n")
                        {
                            isLooping = false;
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid selection!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Division: " + calculator.Divide(n1, n2));
                        Console.WriteLine("Continue? Please type y or n.");
                        resume = Console.ReadLine();

                        if (resume == "y")
                        {
                            isLooping = true;
                        }
                        else if (resume == "n")
                        {
                            isLooping = false;
                        }
                        else
                        {
                            Console.WriteLine("Error: Invalid selection!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Please press enter to exit");
                        Console.ReadLine();
                        isLooping = false;
                        break;
                    default:
                        Console.WriteLine("Error: Invalid selection!");
                        break;
                }
            } while (isLooping == true);
           
        }
        
        public static async Task<String> ConnectToInternet()
        {
            // Connect to the internet
            // Download something

            return "Something";
        }
    }
}
