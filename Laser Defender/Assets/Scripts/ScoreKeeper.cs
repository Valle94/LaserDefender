using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    int initialScore = 0;
    int score;

    public int GetScore()
    {
        return score;
    }

    public void ChangeScore(int value)
    {
        score += value;
        Mathf.Clamp(score, 0, int.MaxValue);
        Debug.Log(score);
    }

    public void ResetScore()
    {
        score = initialScore;
    }
}
