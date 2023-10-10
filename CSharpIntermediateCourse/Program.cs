// See https://aka.ms/new-console-template for more information
StopWatch stopWatch = new StopWatch();

while (true)
{
    Console.WriteLine("Press \"1\" to start, \"2\" to stop and \"3\" to exit.");
    Console.WriteLine("-------------------------------");
    int inputNum = int.Parse(Console.ReadLine());

    if (inputNum == 1)
        break;// stopWatch.Stop();
    else if (inputNum == 2)
        break;
    else
        break;
}
public class StopWatch
{
    private TimeSpan timeExpanded = TimeSpan.Zero;

    public StopWatch()
    {
    }

    public void Start()
    {
        var started = DateTime.Now;
        Console.WriteLine($"Watch started at {started}");
    }
    public void Stop()
    {
        //timeExpanded += DateTime.Now - started;
        Console.WriteLine($"Watch stopped at {DateTime.Now}");
        Console.WriteLine($"Time expanded: {timeExpanded}");
    }
}
