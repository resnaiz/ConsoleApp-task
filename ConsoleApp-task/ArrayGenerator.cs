namespace ConsoleApp_task
{
    public class ArrayGenerator
    {
        public static int[,] GenerateArray(int rows, int columns)
        {
            var array = new int[rows, columns];
            var random = new Random();

            for (var i = 0; i < rows; i++)
            {
                for (var j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            return array;
        }
    }
}
