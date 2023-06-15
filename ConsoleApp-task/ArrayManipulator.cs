namespace ConsoleApp_task
{
    public class ArrayManipulator
    {
        public static int[] FindMinValueCoordinates()
        {
            var array = ArrayContainer.Array;
            var minCoordinate = new int[2];
            var min = array[0, 0];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] >= min) continue;
                    min = array[i, j];
                    minCoordinate[0] = i;
                    minCoordinate[1] = j;
                }
            }

            return minCoordinate;
        }

        public static int[] FindMaxValueCoordinates()
        {
            var array = ArrayContainer.Array;
            var maxCoordinate = new int[2];
            var max = array[0, 0];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] <= max) continue;
                    max = array[i, j];
                    maxCoordinate[0] = i;
                    maxCoordinate[1] = j;
                }
            }

            return maxCoordinate;
        }

        public static int[] SortArray()
        {
            var array = ArrayContainer.Array;
            var sortedArray = new int[array.Length];
            var index = 0;

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    sortedArray[index] = array[i, j];
                    index++;
                }
            }

            Array.Sort(sortedArray);

            return sortedArray;
        }
    }
}
