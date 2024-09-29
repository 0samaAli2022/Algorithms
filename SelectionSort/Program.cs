
List<int> numbers = [5, 35, 49, 25, 2, 7, 4];

List<int> orderedNumbers = SelectionSort(numbers);

PrintList(numbers);

PrintList(orderedNumbers);

static List<int> SelectionSort(List<int> numbers)
{
    var DescNumbers = new List<int>(numbers);
    for(int i =0; i<numbers.Count; i++)
    {
        // searching for maxmimum number's index
        int maxIndex = FindMaxIndex(DescNumbers, i);
        // swapping the maximum number with the current index
        (DescNumbers[maxIndex], DescNumbers[i]) = (DescNumbers[i], DescNumbers[maxIndex]);
    }
    return DescNumbers;
}
static int FindMaxIndex(List<int> numbers, int startIndex)
{
    int maxIndex = startIndex;
    for (int i = startIndex + 1; i < numbers.Count; i++)
    {
        if (numbers[i] > numbers[maxIndex])
        {
            maxIndex = i;
        }
    }
    return maxIndex;
}
static void PrintList(List<int> numbers)
{
    Console.Write("{");
    for (int i = 0; i < numbers.Count; i++)
    {
        Console.Write(numbers[i]);
        if (i < numbers.Count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("}");
}