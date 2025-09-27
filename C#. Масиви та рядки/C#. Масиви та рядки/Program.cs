namespace C_._Масиви_та_рядки
{

    class Program
    {

        static void Main()
        {
            Console.WriteLine("завдання 1");
            PoslidovistTask();

            Console.WriteLine("завдання 2");
            SpilniChislaTask();

        }

        static void PoslidovistTask()
        {
            Console.WriteLine("введіть три числа (обовязково через пробіл!): ");
            string[] chisla = Console.ReadLine().Split();
            int[] poslid;
            poslid = new int[3];

            // -------------------------------------- перенесення чисел //
            for (int i = 0; i < 3; i++)
            {
                poslid[i] = int.Parse(chisla[i]);
            }
           

            int[] masiv = { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            int kilkist = 0;

            // ------------------------------------------- зупинка циклу на останніх 3 числах //
            for (int i = 0; i <= masiv.Length - 3; i++)
            {

                if (masiv[i] == poslid[0] && masiv[i + 1] == poslid[1] && masiv[i + 2] == poslid[2])
                {
                    kilkist++;
                }
            }
            Console.WriteLine("кількість разів: " + kilkist);
        }



        static void SpilniChislaTask()
        {
            int[] masiv = { 1, 2, 3, 4, 5, 6 };
            int[] masiv1 = { 4, 5, 6, 7, 8, 9 };

            int minLen = Math.Min(masiv.Length, masiv1.Length);  // дає верхню межу для 3 масиву //
            int[] masiv3;
            masiv3 = new int[minLen];

            int spl = 0; // ----- кількість спільних ------ //
            for (int m = 0; m < masiv.Length; m++) {
                for (int m1 = 0; m1 < masiv1.Length; m1++)
                {
                    if (masiv[m] == masiv1[m1])
                    {
                        bool isDuplicate = false;

                        for (int i = 0; i < spl; i++) 
                        {
                            if (masiv3[i] == masiv[m])
                            {
                                isDuplicate = true;
                                break;
                            }
                        }

                        if (!isDuplicate)
                        {
                            masiv3[spl] = masiv[m];
                            spl++;
                        }
                    }
                }
            }
            Console.WriteLine("спільні елементи без повторів: ");
            for (int i = 0; i < spl; i++) 
            {
                Console.Write(masiv3[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
