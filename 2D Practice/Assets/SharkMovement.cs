using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkMovement : MonoBehaviour
{
    public float sharkSpeed;
    private Vector2 sharkDirection;
    private Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        sharkDirection = new Vector2(0, directionY).normalized;
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(0, sharkDirection.y * sharkSpeed);
    }
}
