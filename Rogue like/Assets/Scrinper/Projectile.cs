using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    
    
        public float speed;
        public int damage;
        private Transform Player;
        private Vector2 target;
        
        private Health playerHP;
        
        void Start()
        {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector2(Player.position.x,Player.position.y);
        playerHP = GameObject.Find("Player").GetComponent<Health>();
        
        }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);   
        
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestoryProjectile();
        }
    }
    
        void OnTriggerEnter2D(Collider2D other)
    {
       if(other.CompareTag("Player"))
        {
            playerHP.TakeDamage(damage);
            Destroy(gameObject);
        }
        if(other.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
    
    void DestoryProjectile()
    {
        Destroy(gameObject);
    }
}   
