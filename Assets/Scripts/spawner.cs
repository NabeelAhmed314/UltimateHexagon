using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public float spawnRate = 1f;
    public GameObject hexagonPrefab;
    private float nextSpawnTime = 0f;
    public bool countScore;     
    // Update is called once per frame
    void Update()
    {
        if(Time.time >= nextSpawnTime)
        {
            GameObject hexagon = Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity) as GameObject;
            if (countScore)
            {
                Hexagon.countScore = true;
            }
            nextSpawnTime = Time.time + 1f / spawnRate;
        }
    }
}
