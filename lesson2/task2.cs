int[] numbers = { 25, 45, 85, 68, 78 };
min=int.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (min > numbers[i])
    {
        min = numbers[i];
    }
}
Console.WriteLine(min);