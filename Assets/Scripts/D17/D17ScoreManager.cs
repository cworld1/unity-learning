using TMPro;
using UnityEngine;

public class D17ScoreManager : MonoBehaviour
{
    public TMP_Text textScore;
    public float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0f;
        textScore.text = score.ToString() + " Score";
    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString() + " Score";
    }
}
