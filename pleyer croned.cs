using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int speed;
    public float hInput;
    public float vInput;
    // Start is called before the first frame update
    void Start()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal"):
        vInput = Input.GetAxis("Vertical"):
        transform.Translate(Vector3.right * speed * hInput * time.deltataTime);
        transform.Translate(Vector3.right * forward * vInput * time.deltataTime);

        
        
    }
}
