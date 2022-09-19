using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
ScoreManager
scoreManager
*/

public class Balloon : MonoBehaviour
{   public int scoreToGive = 100;
        
    public int clickToPop = 3;
    
    
    private ScoreManager scoreManager;
        
    public float scaleToIncrease = 0.10f;
    
    void Start()
    {
       scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    
    void OnMouseDown()
    {
        clickToPop -= 1;
    
        transform.localScale += Vector3.one * scaleToIncrease;
    
        if(clickToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
