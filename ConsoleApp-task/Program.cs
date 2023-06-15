namespace ConsoleApp_task
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArrayContainer.Array = ArrayGenerator.GenerateArray(20, 20);

            var minCoordinate = ArrayManipulator.FindMinValueCoordinates();
            var maxCoordinate = ArrayManipulator.FindMaxValueCoordinates();
            var sortedArray = ArrayManipulator.SortArray();

            ArrayPrinter.PrintArray();
            ArrayPrinter.PrintMinValue(minCoordinate);
            ArrayPrinter.PrintMaxValue(maxCoordinate);
            ArrayPrinter.PrintSortedArray(sortedArray);

            Console.ReadLine();
        }
    }
}