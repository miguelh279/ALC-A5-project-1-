using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PickUpType
{
    Health,
    Ammo
}

public class Pickup : MonoBehaviour
{
    [Header("Pickup Stats")]
    public PickUpType type;
    public int healthAmount;
    public int ammoAmount;

    [Header ("Bobbing Anim")]
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHeight;

    private Vector3 startPos;
    private bool bobbingUp;
    //public AudioClip pickupSfx;    
    
    void Start()
    {
        //Set the start position
        startPos = transform.position;
    }
    
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            FPSContorller player = other.GetComponent<FPSContorller>();

            switch(type)
            {
                case PickUpType.Health:
                player.GiveHealth(healthAmount);
                break;

                case PickUpType.Ammo:
                player.GiveAmmo(ammoAmount);
                break;
            }     


            Destroy(gameObject);            
            
        }
    }

    void Update()
    {
        //Rotating
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        //Bob Up and Down
        Vector3 offset = (bobbingUp == true ? new Vector3(0,bobHeight / 2, 0) : new Vector3(0, -bobHeight /2, 0));
        transform.position = Vector3.MoveTowards(transform.position, startPos + offset, bobSpeed * Time.deltaTime);

        if(transform.position == startPos + offset)
            bobbingUp = !bobbingUp;
    }
}
