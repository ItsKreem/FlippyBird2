using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    public int ScoreAmount = 10;

    private ScoreManager _scoreManager;

    // Start is called before the first frame update
    void Start()
    {
        _scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (_scoreManager == null)
            return;

        if (!collision.gameObject.CompareTag("Player"))
            return;

        _scoreManager.AddScore(ScoreAmount);
    }
}
