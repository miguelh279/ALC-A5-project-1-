using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{   
    public int maxHealth = 3;
    public int currentHealth;
    public int deathDelat;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
         currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;

        if(currentHealth <= 0)
        {
            Debug.Log("You are dead! Game Over!!");
            Time.timeScale = 0;
            //Destroy(gameObject,deathDelay);
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
