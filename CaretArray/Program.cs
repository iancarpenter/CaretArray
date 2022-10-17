namespace CaretArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 };
            numbers = AddToArray(numbers, 4);

            // use the index from end operator ^
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges#systemindex
            Console.WriteLine($"The last number in the array in {numbers[^1]}");
        }

        static int[] AddToArray(int[] input, int newNumber)
        {
            int[] output = new int[input.Length + 1];

            for(int index = 0; index < input.Length; index++)
            {
                output[index] = input[index];                
            }
             
            output[^1] = newNumber;

            return output;
        }
    }
}