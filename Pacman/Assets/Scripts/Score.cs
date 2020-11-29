using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI txtScore;
    const int pointsPerDotEaten = 3;

    void Start()
    {
        txtScore = FindObjectOfType<TextMeshProUGUI>();
        UpdateScore();
    }

    void Update()
    {
        
    }

    public void IncrementScore()
    {
        UpdateScore();
        score += pointsPerDotEaten;
    }

    public void UpdateScore() => txtScore.text = $"Score: {score}";
}
