class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];
        Random random = new Random();

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = random.Next(-100, 101);
            }
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int min = array[0, 0];
        int max = array[0, 0];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                }

                if (array[i, j] > max)
                {
                    max = array[i, j];
                }
            }
        }

        int sum = 0;
        bool isBetweenMinMax = false;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == min || array[i, j] == max)
                {
                    if (isBetweenMinMax)
                    {
                        isBetweenMinMax = false;
                    }
                    else
                    {
                        isBetweenMinMax = true;
                    }
                }
                else if (isBetweenMinMax)
                {
                    sum += array[i, j];
                }
            }
        }

        Console.WriteLine("Сумма элементов между минимальным ({0}) и максимальным ({1}) элементами: {2}", min, max, sum);
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write("{0,4}", array[i, j]);
            }

            Console.WriteLine();
        }
    }
}