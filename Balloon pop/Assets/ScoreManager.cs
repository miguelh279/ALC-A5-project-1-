using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreText();
    }

    // Update is called once per frame
    public void IncraseScoreText(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()
    {
    
    }
    
    
    
    
}
