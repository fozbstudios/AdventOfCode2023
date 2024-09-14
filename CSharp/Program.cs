static int processLine(String line)
{
    char first = 'a';char last='a';
    
    for (int i = 0; i < line.Length; i++)
    {
        if (Char.IsDigit(line[i]))
        {
            first = line[i];
            break;
        }
    }
    for (int i = line.Length - 1;  i >= 0;  i--)
    {
		if (Char.IsDigit(line[i]))
		{
			last = line[i];
            break;
		}
	}
	return int.Parse("" + first + last);

}
var watch = System.Diagnostics.Stopwatch.StartNew();
int r=File.ReadLines("../../../../input/stock/day1.txt").AsParallel().Sum(line => processLine(line));
watch.Stop();
Console.WriteLine(r);
Console.WriteLine(watch.Elapsed);
