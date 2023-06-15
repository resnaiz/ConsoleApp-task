namespace ConsoleApp_task
{
    public class ArrayPrinter
    {
        public static void PrintArray()
        {
            var array = ArrayContainer.Array;
            Console.WriteLine("20x20 array:");
            Console.WriteLine();

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void PrintMinValue(int[] coordinates)
        {
            var array = ArrayContainer.Array;
            var minValue = array[coordinates[0], coordinates[1]];
            Console.WriteLine("Smallest digit: " + minValue + " (Coordinates: " + coordinates[0] + ", " + coordinates[1] + ")");
        }

        public static void PrintMaxValue(int[] coordinates)
        {
            var array = ArrayContainer.Array;
            var maxValue = array[coordinates[0], coordinates[1]];
            Console.WriteLine("Biggest number: " + maxValue + " (Coordinates: " + coordinates[0] + ", " + coordinates[1] + ")");
        }

        public static void PrintSortedArray(int[] array)
        {
            Console.WriteLine("Selected array in ascending order:");
            Console.WriteLine();

            foreach (var t in array)
            {
                Console.Write(t + " ");
            }

            Console.WriteLine();
        }
    }
}
