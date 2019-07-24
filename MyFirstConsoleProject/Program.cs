using System;

namespace MyFirstConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int answer = Arithmetic.Add(3, 7);
            Console.WriteLine("3 + 7 = " + answer);
            answer = Arithmetic.Sub(10, 6);
            Console.WriteLine("10 - 6 = " + answer);
            answer = Arithmetic.Mult(5, 7);
            Console.WriteLine("5 * 7 = " + answer);
            //answer = Arithmetic.Div(7, 2);
           //Console.WriteLine("7 / 2 = " + answer);
            answer = Arithmetic.Mod(2345, 317);
            bool TorF = Arithmetic.IsEvenlyDivisible(655, 5);
            Console.WriteLine($"655 is evenly divisible by 5: {TorF}");
            
        }
    }
    class Arithmetic
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Sub(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
            //the 'public' above sets the Access Modifier such that it is accessible to all classes now and any in the future.
            // 'public' is the most open Access Modifier

            // the default Access Modifier is 'private' for Methods.  'private' is accessibles only to the class it is in.
        {
            return a * b;
            }
        private static int Div(int a, int b)
            // the 'private' above sets the Access Modifier such that it is accessible only by the current class (in this case 'Arithmetic' ).
            // 'private' is the most restrictive Access Modifier
        {
            return a / b;
        }
        internal static int Mod(int a, int b)
        {
            int ans = a % b;
            Console.WriteLine($"{a} mod {b} = {ans}");
            // the $ above allows for interpolation such that the variables are presented in the text string when shown on the console
            return ans;
            // placing the 'ans' after return means the return will use the "int ans = a % b" result above
        }
        public static bool IsEvenlyDivisible(int a, int b) {
            return Mod(a, b) == 0;
            // Is a call to 'Mod' above. We don't need to put 'Arithmetic' because it understands it is from the current class
        }
    }
}
