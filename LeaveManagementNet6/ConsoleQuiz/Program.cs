int invalidNumbers = 0;
int NaNs = 0;
int[] ints = new int[10];
string[] given = { "7", "2", "4", "2", "q", "87", "4", "6", "4", "4", "7" };
for (int i = 0; i < given.Length; i++)
{
    int number;
    bool isParsable = Int32.TryParse(given[i], out number);
    if (isParsable)
    {
        if (number >= 0 && number <= 10)
        {
            ints[number]++;
        }
        else 
            invalidNumbers++;
    }
    else
        NaNs++;
}
for (int i = 0; i < ints.Length; i++)
{
    if (ints[i] > 0)
    {
        Console.WriteLine($"#{i}:\t{ints[i]}");
    }
}
Console.WriteLine($"invalid:\t{invalidNumbers}");
Console.WriteLine($"NAN:\t{NaNs}");
