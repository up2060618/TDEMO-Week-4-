using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallAI : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1.5f, 0);
    }
}
   
