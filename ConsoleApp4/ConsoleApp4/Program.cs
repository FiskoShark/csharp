class Number
{
    static void Main()
    {
        Console.Write("введіть число A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("введіть число B: ");
        int B = int.Parse(Console.ReadLine());

        Console.WriteLine("\nпарні числа, від A до B: ");
        for (int i = A; i <= B; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine("\n\nнепарні числа від A до B: ");
        int j = A;
        while (j <= B)
        {
            if (j % 2 != 0)
            {
                Console.Write(j + " ");
            }
            j++;
        }

        Console.WriteLine();
    }
}
