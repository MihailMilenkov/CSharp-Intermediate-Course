// See https://aka.ms/new-console-template for more information
StopWatch stopWatch = new StopWatch();

while (true)
{
    Console.WriteLine("Press \"1\" to start, \"2\" to stop and \"3\" to exit.");
    Console.WriteLine("-------------------------------");
    int inputNum = int.Parse(Console.ReadLine());

    if (inputNum == 1)
        stopWatch.Start();
    else if (inputNum == 2)
        stopWatch.Stop();
    else
        break;
}
public class StopWatch
{
    private TimeSpan timeElapsed = TimeSpan.Zero;
    private DateTime started;
    private bool stopWatchIsOn = false;
    public StopWatch()
    {
    }

    public void Start()
    {
        if (stopWatchIsOn)
        {
            //throw new InvalidOperationException("The StopWatch is already on."); // different approach
            timeElapsed = DateTime.Now - started;
            Console.WriteLine();
            Console.WriteLine("The StopWatch is already on");
            Console.WriteLine($"Time elapsed: {timeElapsed}");
            Console.WriteLine();
        }
        else
        {
            timeElapsed = TimeSpan.Zero; // this implementation resets the timer
            stopWatchIsOn = true;
            started = DateTime.Now;
            Console.WriteLine();
            Console.WriteLine($"StopWatch started at {started}");
            Console.WriteLine($"Time elapsed: {timeElapsed}");
            Console.WriteLine();
        }
    }
    public void Stop()
    {
        
    }

}
