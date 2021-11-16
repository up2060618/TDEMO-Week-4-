using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Transform FirePoint;
 public Transform Player;
 public GameObject Projectile;
 public float fireRate = 15f;
 public float MoveSpeed = 0.1f;
    public Animator animator;
 private float nextShot = 0f;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        
            // SHOOT
    if (Input.GetKey("space") && Time.time >= nextShot)
    {
            animator.SetTrigger("shoot");
      nextShot = Time.time + 1f/fireRate;
      Shoot();
            //animator.SetBool("shoot", false);
        } 
    // MOVE UP
  
    if (Input.GetKey(KeyCode.W))
    {
    transform.position = transform.position + new Vector3(0, MoveSpeed, 0);


    }



    // MOVE DOWN
    if (Input.GetKey(KeyCode.S))
    {
     transform.position = transform.position + new Vector3(0, -MoveSpeed, 0);
    }




      // Move Right 
        if (Input.GetKey(KeyCode.D))
    {
    transform.position = transform.position + new Vector3(MoveSpeed, 0, 0);

        
    }

    // Move Left

        if (Input.GetKey(KeyCode.A))
    {
    transform.position = transform.position + new Vector3(-MoveSpeed, 0, 0);

        
    }


    }


 public void Shoot()
 {
 
  GameObject Proj = (GameObject)Instantiate(Projectile, FirePoint.position, FirePoint.rotation);
  Destroy(Proj, 1f);

 }
}
