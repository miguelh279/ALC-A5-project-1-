using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int Key;
    
    public void AddKey(int amount)
    {
        Key += amount; Debug.Log("Keys ="+ Key);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
