using System;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] symbols = args[0].Split(" ");
        int count = 0;
        int result = 0;
        string[] buffer = new string[30];
        int bufIndex = 0;

        for(int i = 0; i < symbols.Length; i++)
        {
            count++;
            bool flag = true;
            for (int j = 0; j < buffer.Length; j++)
            {

                if (buffer[j] == symbols[i])
                {
                    if (result < count - 1)
                    { 
                        result = count - 1; 
                    }
                    
                    count = 1;
                    flag = false;

                }
            }
            
            if(flag) 
            { 
                buffer[bufIndex] = symbols[i];
                bufIndex++;
            }
        }
        Console.WriteLine(string.Join(", ", symbols));
        Console.WriteLine("Result is: " + result);
    }

}