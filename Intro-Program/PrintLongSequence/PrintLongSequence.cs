using System;

class PrintLongSequence
{
    static void Main()
    {
        int a = 1;
            for (int i = 2; i < 1002; i++)
            {
                Console.Write(i*a + " ");
                a=a*-1;
            }
    }
}

