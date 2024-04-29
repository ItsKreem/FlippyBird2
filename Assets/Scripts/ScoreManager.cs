using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public AudioSource ScoreAudio;
    public void AddScore(int score)
    {
        Score += score;
        Debug.Log("Current score = " + Score);
        if (ScoreAudio != null)
        {
            GameObject.Instantiate(ScoreAudio, transform.position, Quaternion.identity);
        }
    }
}
