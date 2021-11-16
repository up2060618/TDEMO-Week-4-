using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHiggins : MonoBehaviour
{
    public GameObject Higgins;
    public static bool higginsSpawned = false;
    // Update is called once per frame
    void Update()
    {
        if (ScoreScript.ScoreCount >= 35 && !higginsSpawned)
        {
            SpawnBarrels.timeBetweenSpawn = 10000000000000000000;
            SpawnBoats.timeBetweenSpawn = 10000000000000000000;
            SpawnSubmarines.timeBetweenSpawn = 10000000000000000000;
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(Higgins, transform.position + new Vector3(3.3f, 0, 0), transform.rotation);
        higginsSpawned = true;
    }
}
