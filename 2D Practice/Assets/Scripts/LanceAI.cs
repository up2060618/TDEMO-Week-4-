using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanceAI : MonoBehaviour
{
   
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-7.5f, 0);
    }

}
