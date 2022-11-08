using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{   
    public int maxhealth = 3;
    public int currentHealth;
    public int deathDelat;
    
    // Start is called before the first frame update
    void Start()
    {
         currentHealth = maxhealth
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= healAmount;
        
        if(currentHealth <= 0)
        {
            
        }
    }
}
