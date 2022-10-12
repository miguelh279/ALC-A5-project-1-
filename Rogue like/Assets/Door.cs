using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameManager gm;
    public float doorDelay = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("player")&& gm.Key >= 1)
            {
                Destroy(gameObject, doorDelay);
                gm.Key --;
                Debug.Log("Key = "+ gm.Key);
                Debug.Log("Door is open");
            }
            else
            {
            Debug.Log("Door is lock you need a key");
            }
    }
}