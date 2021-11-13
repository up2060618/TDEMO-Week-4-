using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelHealth : MonoBehaviour
{
    private int Health;

    void Start()
    {
        Health = 20;
    }


    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);
        }

    }


     void OnCollisionEnter2D(Collision2D other)
    {

    if (other.gameObject.tag == "Projectile")
    {
     Health = Health - 1;
    }

    }






}
