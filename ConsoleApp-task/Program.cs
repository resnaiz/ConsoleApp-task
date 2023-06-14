namespace ConsoleApp_task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new int[20, 20];
            var random = new Random();

            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            Console.WriteLine("20x20 array:");
            Console.WriteLine();

            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            var minCoordinateA = 0;
            var minCoordinateB = 0;
            var maxCoordinateA = 0;
            var maxCoordinateB = 0;
            var min = array[0, 0];
            var max = array[0, 0];

            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minCoordinateA = i;
                        minCoordinateB = j;
                    }

                    if (array[i, j] <= max) continue;
                    max = array[i, j];
                    maxCoordinateA = i;
                    maxCoordinateB = j;
                }
            }

            Console.WriteLine("Smallest digit: " + min + " (Coordinates: " + minCoordinateA + ", " + minCoordinateB + ")");
            Console.WriteLine("Biggest number: " + max + " (Coordinates: " + maxCoordinateA + ", " + maxCoordinateB + ")");

            var sortedArray = new int[400];
            var index = 0;

            for (var i = 0; i < 20; i++)
            {
                for (var j = 0; j < 20; j++)
                {
                    sortedArray[index] = array[i, j];
                    index++;
                }
            }

            Array.Sort(sortedArray);

            Console.WriteLine();
            Console.WriteLine("Selected array in ascending order:");
            Console.WriteLine();

            for (var i = 0; i < 400; i++)
            {
                Console.Write(sortedArray[i] + " ");
            }

            Console.ReadLine();
        }
    }
}