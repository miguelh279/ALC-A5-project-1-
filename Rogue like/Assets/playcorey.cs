using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playcorey : MonoBehaviour
{
    public float speed;
    public float hIput;
    public float vIput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        hIput = Input.GetAxis("Horizontal");
        vIput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector2.right * hIput * speed * Time.deltaTime);
        // Move left and right
        
        transform.Translate(Vector2.up * vIput * speed * Time.deltaTime);
        // Move forward and back
    }
}