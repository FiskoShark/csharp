namespace C_._Масиви_та_рядки2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введіть речення: ");
            string rechennya = Console.ReadLine();

            slova(rechennya);
            obertSliv(rechennya);
        }



        static void slova(string rechennya)
        {
            string[] slovaa;
            slovaa = rechennya.Split(new char[] {},
            StringSplitOptions.RemoveEmptyEntries);  // для прибирання "пустих" елементів - подвійні пробіли наприклад //

            Console.WriteLine($"кількість слів: {slovaa.Length}");
        }



        static void obertSliv(string rechennya)
        {
            string[] slovaa;
            slovaa = rechennya.Split(new char[] {}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < slovaa.Length; i++)
            {
                char[] revers = slovaa[i].ToCharArray();
                Array.Reverse(revers);
                slovaa[i] = new string(revers);
                // розбирання вмісту - оберт - збирання //
            }
            string reversedRechennya;
            reversedRechennya = string.Join(" ", slovaa);
            Console.WriteLine("результат: " + reversedRechennya);
        }
    }
}

