// See https://aka.ms/new-console-template for more information
//StopWatch stopWatch = new StopWatch();
//stopWatch.TurnOn();
StackOverflowPost post = new StackOverflowPost();
//post.TurnOn();

public class StackOverflowPost
{
    private int voteValue = 0;

    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; set; }

    public int VoteValue { get => voteValue; }
}