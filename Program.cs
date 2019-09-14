using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World");
            //Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            //Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            //const float Pi = 3.14f;

            int i = 1000;
            byte b = (byte) i;
            Console.WriteLine(b);
    
            //int a = Convert.ToInt32(number);

            try
            {
                /*string number = "1224";
                byte b1 = Convert.ToByte(number);
                Console.WriteLine(b1);*/
                string str = "true";
                bool b1 = Convert.ToBoolean(str);
                Console.WriteLine(b1);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to a byte");

                //throw;
            }

            //Console.WriteLine(a);
            
        }
    }
}
