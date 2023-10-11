// See https://aka.ms/new-console-template for more information
public class StopWatch
{
    private TimeSpan timeElapsed = TimeSpan.Zero;
    private DateTime started;
    private bool stopWatchIsOn = false;

    internal void TurnOn()
    {
        while (true)
        {
            Console.WriteLine("Press \"1\" to start, \"2\" to stop and \"3\" to exit.");
            Console.WriteLine("-------------------------------");
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum == 1)
                Start();
            else if (inputNum == 2)
                Stop();
            else
                break;
        }
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
            timeElapsed = TimeSpan.Zero; // this implementation resets the timer on every start
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
        if (stopWatchIsOn)
        {
            stopWatchIsOn = false;
            Console.WriteLine();
            Console.WriteLine($"Watch stopped at {DateTime.Now}");
            Console.WriteLine($"Time elapsed: {timeElapsed}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Watch is already stopped");
            Console.WriteLine($"Time elapsed: {timeElapsed}");
            Console.WriteLine();
        }
    }
}
