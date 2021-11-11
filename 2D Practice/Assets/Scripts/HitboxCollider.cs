using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxCollider : MonoBehaviour
{
    public Collider2D Enemy;
   void OnTriggerEnter2D(Collider2D col)
   {
     HealthBarControl.health -= 1; //will reduce the players life when trigger
   }
}
