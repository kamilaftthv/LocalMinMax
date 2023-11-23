class Program
{
    static void Main()
    {
        int day = int.Parse(Console.ReadLine());
        if (day < 3)
        {
            Console.WriteLine("Количество дней должно быть больше 3");
            return;
        }
        int[] temp = new int[day];
        for (int i = 0; i < day; i++)
        {
            temp[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < day - 1; i++)
        {
            if (temp[i] > temp[i - 1] && temp[i] > temp[i + 1])
            {
                Console.WriteLine($"day {i+1} : {temp[i]} (max)");
            }
            if (temp[i] < temp[i - 1] && temp[i] < temp[i + 1])
            {
                Console.WriteLine($"day {i+1} : {temp[i]} (min)");
            }
        }
    }
}