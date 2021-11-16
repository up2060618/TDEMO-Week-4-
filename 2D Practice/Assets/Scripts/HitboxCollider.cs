using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxCollider : MonoBehaviour
{
    public Collider2D Enemy;
    public GameObject Projectile;
   void OnTriggerEnter2D(Collider2D col)
   {
        HealthBarControl.health -= 1; //will reduce the players life when trigger
        Projectile.SetActive(false);
   }
}
