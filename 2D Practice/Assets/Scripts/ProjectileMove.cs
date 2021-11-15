using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed = 30f;
 
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }


    void OnCollisionEnter2D(Collision2D other)
    {
    
    Destroy(gameObject);

    }
}
