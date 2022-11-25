static class Maths
{
    static public int Min(int num1, int num2) => num1 < num2 ? num1 : num2;

    static public int Max(int num1, int num2) => num1 > num2 ? num1 : num2;

    static public int Factorial(int num) => num == 0 ? 1 : num * Factorial(num - 1);

    static public List<int> Sort(List<int> numbers)
    {
        List<int> sortedNumbers = new List<int>();

        while (numbers.Count > 0)
        {
            int min = numbers[0];
            int minIndex = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                    minIndex = i;
                }
            }

            sortedNumbers.Add(min);
            numbers.RemoveAt(minIndex);
        }

        return sortedNumbers;

    }
}