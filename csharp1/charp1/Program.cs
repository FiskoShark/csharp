using System;
class Program
{

    static void Main()
    {
        int ocinka1;
        int ocinka2;
        int ocinka3;
        bool hasFailingGrade = false;

        //--------------------------------------
        Console.Write("введіть першу оцінку: ");
        ocinka1 = int.Parse(Console.ReadLine());

        Console.Write("введіть другу оцінку: ");
        ocinka2 = int.Parse(Console.ReadLine());

        Console.Write("введіть третю оцінку: ");
        ocinka3 = int.Parse(Console.ReadLine());

        //---------------------------------------
        if (ocinka1 < 50 || ocinka2 < 50 || ocinka3 < 50)
        {
            hasFailingGrade = true;
        }


        double average = (ocinka1 + ocinka2 + ocinka3) / 3.0;
        Console.WriteLine("\nсередній бал: " + average);




        if (hasFailingGrade)
        {
            Console.WriteLine("студент не склав курс, присутній бал нижче 50 :(");
        }
        else if (average < 60)
        {
            Console.WriteLine("потрібні додаткові заняття, присутній бал нижче 60.");
        }
        else
        {
            Console.WriteLine("студент успішно склав курс! :D");
        }
    }
}
