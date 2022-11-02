using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        public float speed;
        private Transform Player;
        private Vector2 target;
        
        void Start()
        {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(player.podsition.x,player,podsition.y);
        
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);   
        
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestoryProjectile();
        }
    }
    
    void DestoryProjectile()
    {
        DestoryProjectile();
    }
}   
