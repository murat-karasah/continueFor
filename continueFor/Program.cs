﻿using System;

namespace continueFor
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <10 ; i++)
            {
                if (i==3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
