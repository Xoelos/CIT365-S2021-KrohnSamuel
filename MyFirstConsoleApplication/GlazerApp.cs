﻿using System;

namespace MyFirstConsoleApplication
{
    static class GlazerApp
    {
        static public void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please provide a width value: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please provide a height value: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");
        }
    }
}
