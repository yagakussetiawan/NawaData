using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input the number of families : ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Input the number of members in the family (separated by a space) : ");
        string[] membersInput = Console.ReadLine().Split(' ');
        if (membersInput.Length != n)
        {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }
        int[] members = membersInput.Select(int.Parse).ToArray();
        int busCount = 0;
        for (int i = 0; i < n; i++)
        {
            if (members[i] > 4)
            {
                busCount += (int)Math.Ceiling(members[i] / 4.0); 
            }
            else
            {
                busCount++; 
                if (i + 1 < n && members[i] + members[i + 1] <= 4) 
                {
                    i++; 
                }
            }
        }

        Console.WriteLine($"Minimum bus required is : {busCount}");
    }
}