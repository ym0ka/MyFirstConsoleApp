namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Variable : camelCase
            int number = 1;
            //Constant : PascalCase
            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine(Pi);
            //String template filled with variables
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
            //Basic test of overflowing a variable
            try
            {
                checked
                {
                    byte maxBite = byte.MaxValue;
                    maxBite++;
                    Console.WriteLine(maxBite);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception volontaire : " + e.Message);
                // Removed throw; to avoit e
            }
            
        }

    }
}