namespace CaretArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ListOf<int> numbers = new ListOf<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            
            Console.WriteLine(numbers.GetItemAt(2));

            ListOf<string> strings = new ListOf<string>();

            strings.Add("Hello");
            strings.Add("Generics");

            Console.WriteLine(strings.GetItemAt(0));                        
        }       
    }

    public class ListOf<T>
    {
        private T[] _numbers = new T[0];

        public T GetItemAt(int index) => _numbers[index];
        public void SetItemAt(int index, T value) => _numbers[index] = value;

        public void Add(T newValue)
        {
            T[] updated = new T[_numbers.Length + 1];

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