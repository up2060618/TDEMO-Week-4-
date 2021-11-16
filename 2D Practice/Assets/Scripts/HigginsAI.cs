using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HigginsAI : MonoBehaviour
{
    // Start is called before the first frame update

    public static float spawnTime;
    public GameObject HigginsBorder;
    void Start()
    {
        spawnTime = Time.time;
        GetComponent<CircleCollider2D>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time > spawnTime + 8)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
            GetComponent<CircleCollider2D>().enabled = true;
        }

        switch (GetComponent<BarrelHealth>().Health)
        {
            case 400: GetComponent<Transform>().localScale = new Vector3(2, 2, 2);
                break;
            case 300:
                GetComponent<Transform>().localScale = new Vector3(3, 3, 3);
                break;
            case 200:
                GetComponent<Transform>().localScale = new Vector3(4, 4, 4);
                break;
            case 100:
                GetComponent<Transform>().localScale = new Vector3(5, 5, 5);
                break;
            case 0:
                SceneManager.LoadScene(2);
                break;

        }

    }
}
