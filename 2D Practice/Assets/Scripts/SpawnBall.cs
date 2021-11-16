using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject DarkBall;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public static float timeBetweenSpawn = 2;
    private float spawnTime;


    // Update is called once per frame
    void Update()
    {
        if ((Time.time > spawnTime) && (SpawnHiggins.higginsSpawned == true))
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(DarkBall, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
