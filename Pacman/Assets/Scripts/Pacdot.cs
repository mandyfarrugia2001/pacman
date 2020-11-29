using UnityEngine;

public class Pacdot : MonoBehaviour
{
    DotsManager dotsManager;
    Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
        dotsManager = FindObjectOfType<DotsManager>();
        dotsManager.CountDots();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag.Equals("Pacman"))
        {
            Destroy(gameObject);
            dotsManager.RemoveDot();
            score.IncrementScore();
        }
    }
}
