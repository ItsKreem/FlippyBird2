using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public TMP_Text ScoreUI;
    private ScoreManager _scoreManager;

    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
        ScoreUI = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_scoreManager == null || ScoreUI == null)
            return;
        
        ScoreUI.text = "SCORE: " + _scoreManager.Score.ToString();
    }
}
