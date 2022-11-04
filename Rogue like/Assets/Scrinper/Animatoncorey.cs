using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animationcorey : MonoBehaviour
{
    public Animator animSpeed;
    // Start is called before the first frame update
    void Start()
    {
        animSpeed = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        StopAnim();
        
            if(Input.GetKeyDown(KeyCode.O))
        StopAnim();
    }

    void PlayAnim()
    {
        animSpeed.speed = 1f;
        Debug.Log("Animation is Playing");
    }
    
    void StopAnim()
    {
        animSpeed.speed = 0f;
        Debug.Log("Animation is Stop");
    }

}
