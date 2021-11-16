using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubmarineAI : MonoBehaviour
{
    public float spawnTime;
    public float shotTime = 0;
    public bool notMoving = true;
    public GameObject SubmarineProjectile;

    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((notMoving) && (Time.time > spawnTime + 5))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
            notMoving = false;
        }
        if ((!(notMoving)) && (Time.time > shotTime + 3))
        {
            GameObject SubProj = (GameObject)Instantiate(SubmarineProjectile, GetComponent<Transform>().position, Quaternion.identity);
            shotTime = Time.time;
            Destroy(SubProj, 15f);
        }
    }
}
