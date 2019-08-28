﻿using System;
using System.Linq;

class Difference
{
    int[] elements;
    public int maximumDifference;

    public Difference(int[] elements)
    {
        this.elements = elements;
    }

    public void computeDifference()
    {
        int max = 0;

        for (int i = 0; i < elements.Length; i++)
        {
            for (int j = 0; j < elements.Length; j++)
            {
                int abs = Math.Abs(elements[i] - elements[j]);
                if (abs > max) max = abs;
            }
        }

        maximumDifference = max;
    }

    // Add your code here

} // End of Difference Class

class Solution
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());

        int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

        Difference d = new Difference(a);

        d.computeDifference();

        Console.Write(d.maximumDifference);
    }
}