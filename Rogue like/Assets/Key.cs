using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : PickUp
{
    public int key;
    
    public void AddKey(int amout)
    
    {
        key += amount;
        Debug.Log("Keys = "+key);   
    }
}
