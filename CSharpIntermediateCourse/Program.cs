// See https://aka.ms/new-console-template for more information
//StopWatch stopWatch = new StopWatch();
//stopWatch.TurnOn();
StackOverflowPost post = new StackOverflowPost();
post.TurnOn();

public class StackOverflowPost
{
    private int voteValue = 0;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; set; }

    public int VoteValue { get => voteValue; }

    internal void TurnOn()
    {
        while (true)
        {
            Console.WriteLine("Press \"1\" to UpVote, \"2\" to DownVote and \"3\" to exit.");
            Console.WriteLine("-------------------------------");
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum == 1)
                Vote(1);
            else if (inputNum == 2)
                Vote(-1);
            else
            {
                Console.WriteLine($"Current votes: {voteValue}");
                break;
            }
        }
    }

    internal void Vote(int vote)
    {
        this.voteValue += vote;
    }
}