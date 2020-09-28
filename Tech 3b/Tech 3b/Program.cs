using System;

namespace Tech_3b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Element Value:");
            try
            {
                
                string input = Console.ReadLine();
                int value_of_input = int.Parse(input);
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("1-25");
                    
                    
                    
                        
                                     
                    Console.ReadKey(true);
                }
                
                else if ((value_of_input > 10) && (value_of_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("1-25");
                    Console.WriteLine("1-25");
                    
                    
                    
                    for (int i = 0; i < value_of_input; i++)
                    {
                       
                        Console.Write(i + " ");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("__________________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program ...");
                    Console.ReadKey(true);
                } 
               
                
            } 
            
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } 
        }
    }
}
           