using UnityEngine;

public class Manager
{
    public static int Score
    {
        get => PlayerPrefs.GetInt("Score", 0);
        set => PlayerPrefs.SetInt("Score", value);
        
    }
   

    public static int InitLevelPoints{
        get => PlayerPrefs.GetInt("InitLevelPoints", 0);
        set => PlayerPrefs.SetInt("InitLevelPoints", value);
        
    }

    public static void InitGame()
    {
        Score = 0;
        PlayerPrefs.Save();
       
    }

    public static void AddScore(int points)
    {
        Score += points;
        PlayerPrefs.Save();
    }

    public static void InitLevelScore()
    {
        InitLevelPoints=Score;
    }

    public static void SetScore()
    {
        Score= InitLevelPoints;
    }
}