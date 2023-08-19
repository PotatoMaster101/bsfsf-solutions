namespace Section04.Shared;

public partial class ExperimentalLayout
{
    private int _downvotes;
    private int _upvotes;

    private void Downvote()
    {
        _downvotes++;
        Logger.LogInformation("Downvotes = {Downvotes}", _downvotes);
    }

    private void Upvote()
    {
        _upvotes++;
        Logger.LogInformation("Upvotes = {Upvotes}", _upvotes);
    }
}
