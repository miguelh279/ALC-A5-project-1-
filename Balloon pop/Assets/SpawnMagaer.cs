using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMagaer : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;
    public float xRange = 10f;
    
    
    void start()
    {
        InvokeRepeating("SpawnRandomBalloon" , startDelay,spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        Vector3 Spawnpos = new Vector3(Random.Range(-xRange,xRange),10,0);
        
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        
        Instantiate(balloonPrefabs[balloonIndex], Spawnpos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
