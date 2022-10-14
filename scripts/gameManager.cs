using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class gameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
  
    public void UpdateScore()
    {
        score++;
        scoreText.text=score.ToString();
    }
}
