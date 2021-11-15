using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

  private int Health;
    public GameObject Player;
    public ScoreScript Score;    

    void Start()
    {
        Player = GameObject.Find("shark (player sprite)");
        Score = Player.GetComponent<ScoreScript>();
        Health = 20;
    }


    // Update is called once per frame
    void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject);
            Score.ScoreCount = Score.ScoreCount + 1;
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
