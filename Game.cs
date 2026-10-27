public class Play
{
    public string NameGame;
    public int rating;
    public int reviews;
    public int Number_of_all_game;

    public Play(string name, int ball)
    {
        NameGame = name;
        rating = ball;
        reviews = 100;
        Number_of_all_game = 1;
    }
}