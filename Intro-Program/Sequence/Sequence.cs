using System;


namespace Sequence
{
    class Sequence
    {
        static void Main()
        {
            for (int i = 2; i < 12; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i);
                    Console.Write(", ");
                }
                else
                {
                    Console.Write(-i);
                    Console.Write(", ");
                }
            }
        }
    }
}