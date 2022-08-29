using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public float rotSpeed;
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
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up,rotSpeed * hInput * Time.deltaTime);
        transform.Translate(Vector3.forward * speed * vInput * Time.deltaTime);        
        
    }
}
