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

                int number = Convert.ToInt32(line);

                int fact = 1;

                for(int i=1;i<=number;i++) {

                    fact = fact*i;

                }

                Console.WriteLine(fact);

            }

           

        }

    }

}
