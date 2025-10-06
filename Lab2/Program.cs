namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "-1";

            Console.WriteLine("Лабораторная 2\n~~~~~~~~~~~~~~~~\n");
            Console.WriteLine("Задания:\n");
            Console.WriteLine("1 - Время");
            Console.WriteLine("2 - Дом");
            Console.WriteLine("3 - Сотрудники и отделы");
            Console.WriteLine("4 - Создаём дом");
            Console.WriteLine("5 - Пистолет стреляет\n");

            while (choice != "0")
            {
                Console.WriteLine("\nВведите номер задания или 0 для выхода:");
                choice = Console.ReadLine();
                Tasks.Choose(choice);
            }
        }
    }
}
