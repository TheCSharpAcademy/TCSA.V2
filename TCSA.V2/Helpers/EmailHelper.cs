using TCSA.V2.Data;

namespace TCSA.V2.Helpers;

public static class EmailHelper
{
    public static string GetProjectCompletedBody(string firstName, string title, int experiencePoints, string rankingText)
    {
        return @$"Hello <b>{firstName}</b><p><p>Well done! We have just reviewed and approved your <b>{title}</b> project..<p><p>You've gained <b>{experiencePoints}</b> Experience Points and moved to the <b>{rankingText}</b> position on our leaderboard.  Don't forget that marking our articles as read also gives you experience points!<p><p>Keep up the good work!<p><p><b>The C# Academy Team</b>";
    }

    public static string GetNewDiscordAliasAdded(string userId, Level level, string discordAlias)
    {
        return @$"User {userId}, level {level} changed Discord alias to {discordAlias}.";
    }
}
