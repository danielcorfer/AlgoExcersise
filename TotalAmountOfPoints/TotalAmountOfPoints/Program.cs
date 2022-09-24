using System.Linq;

public static class Kata
{

    static void Main(string[] args)
    {
        string[] games = new string[]
        {
            "3:1","2:1","1:1","2:1","0:1","2:1","1:1","0:1","1:1","2:1"
        };

        Console.WriteLine(TotalPoints(games));
        Console.WriteLine(TotalPointsLinq(games));
    }
    public static int TotalPoints(string[] games)
    {
        int firstTeamPoints = 0;
        int secondTeamPoints = 0;
        string[] splittedScore = new string[games.Length - 1];

        foreach (var item in games)
        {
            splittedScore = item.Split(item[1]);

            for (int i = 0; i < splittedScore.Length; i += 2)
            {
                int countedScore = Convert.ToInt32(splittedScore[i]) - Convert.ToInt32(splittedScore[i + 1]);

                switch (countedScore)
                {
                    case > 0:
                        firstTeamPoints += 3;
                        break;
                    case < 0:
                        secondTeamPoints += 3;
                        break;
                    case 0:
                        secondTeamPoints++;
                        firstTeamPoints++;
                        break;
                }
            }
        }
        return firstTeamPoints;
    }



    public static int TotalPointsLinq(string[] games)
    {
        int points = 0;
        foreach (var item in games)
        {
            points += item[0] > item[2] ? 3 : item[0] == item[2] ? 1 : 0;
        }
        return points;
        //return games.Sum(s => s[0] > s[2] ? 3 : s[0] == s[2] ? 1 : 0);
    }
}