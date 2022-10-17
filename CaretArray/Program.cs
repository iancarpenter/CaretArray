namespace CaretArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListOfNumbers numbers = new ListOfNumbers();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            
            Console.WriteLine(numbers.GetItemAt(2));
                        
        }       
    }

    public class ListOfNumbers
    {
        private int[] _numbers = new int[0];

        public int GetItemAt(int index) => _numbers[index];
        public void SetItemAt(int index, int value) => _numbers[index] = value;

        public void Add(int newValue)
        {
            int[] updated = new int[_numbers.Length + 1];

            for (int index = 0; index < _numbers.Length; index++)
            {
                updated[index] = _numbers[index];
            }

            // use the index from end operator ^
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/ranges#systemindex           
            updated[^1] = newValue;

            _numbers = updated;
        }
    }
}