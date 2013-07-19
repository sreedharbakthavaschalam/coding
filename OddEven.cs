using System.IO;
using System;

class Program
{
    static void Main()
    {
        // Read in every line in the file.
        using (StreamReader reader = new StreamReader("input.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
                int num;
                Console.WriteLine("enter the num");
                num = Convert.ToInt32(line);
                if((num % 2) == 0){
                   Console.WriteLine("given num is even", num);
                }
                else{
                   Console.WriteLine("given num is odd", num);
                }
            }
        }
    }
}
