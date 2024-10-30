using System;

namespace KASDLab14
{
    internal class Program
    {
        static void Main()
        {
            int[] array = { 1, 8, 2, 4, 5, 1, 8, 4, 7 };
            Console.WriteLine("Инициализация массивом { 1, 8, 2, 4, 5, 1, 8, 4, 7 }:");
            MyArrayDeque<int> arrayDeque = new MyArrayDeque<int>(array);
            arrayDeque.Print();

            Console.WriteLine($"Попытка добавления 2: {arrayDeque.OfferFirst(2)}");

            arrayDeque.Add(2);
            Console.WriteLine("Добавление 2:");
            arrayDeque.Print();

            arrayDeque.Remove(2);
            Console.WriteLine("Удаление 2:");
            arrayDeque.Print();

            arrayDeque.AddFirst(11);
            Console.WriteLine("Добавление 11 в голову:");
            arrayDeque.Print();

            arrayDeque.Add(13);
            Console.WriteLine("Добавление 13:");
            arrayDeque.Print();

            arrayDeque.Pull();
            Console.WriteLine("Удаление с головы:");
            arrayDeque.Print();

            arrayDeque.RemoveFirstOccurrence(4);
            Console.WriteLine("Удаление первого вхождения 4:");
            arrayDeque.Print();

            arrayDeque.RemoveLastOccurrence(8);
            Console.WriteLine("Удаление последнего вхождения 8:");
            arrayDeque.Print();

            arrayDeque.AddFirst(52);
            Console.WriteLine("Добавление 52 в голову:");
            arrayDeque.Print();

            Console.WriteLine("Первый элемент с хвоста:");
            Console.WriteLine(arrayDeque.GetLast());
            Console.WriteLine("Удалили элемент с хвоста:");
            arrayDeque.PullLast();
            arrayDeque.Print();

            Console.WriteLine("Размер двунаправленной очереди:");
            Console.WriteLine(arrayDeque.Size());

            Console.ReadKey();
        }
    }
}
