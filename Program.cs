// See https://aka.ms/new-console-template for more information
List<int> valuesList = new List<int> {1,2,3,4,5,6,7};

valuesList.ForEach(x => Console.WriteLine(x));

Console.WriteLine("My index number is 32750");

Console.WriteLine("fake commmit 2");

Console.WriteLine("fake commmit 3");


'function to find average from int[] values'
int CalculateAverage(int[] values)
{
    int sum = 0;
    for (int i = 0; i < values.Length; i++)
        sum += values[i];

    return (sum / values.Length);
}

"function to find max value from int[] values"
int CalculateMax(int[] values)
{
    int max = values[0];
    for (int i = 1; i < values.Length; i++)
        if (values[i] > max)
            max = values[i];

    return max;
}


"function to find min value from int[] values!!" 
int CalculateMin(int[] values)
{
    int min = values[0];
    for (int i = 1; i < values.Length; i++)
        if (values[i] < min)
            min = values[i];

    return min;
}