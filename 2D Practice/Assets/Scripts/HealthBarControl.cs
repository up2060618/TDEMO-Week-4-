using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarControl : MonoBehaviour
{
    public GameObject Life, Life1, Life2, gameOver;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        Life.gameObject.SetActive(true);
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        switch (health)
        {

            case 3:
                Life.gameObject.SetActive(true);
                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(true);
                break;

            case 2:
                Life.gameObject.SetActive(true);
                Life1.gameObject.SetActive(true);
                Life2.gameObject.SetActive(false);
                break;

            case 1:
                Life.gameObject.SetActive(true);
                Life1.gameObject.SetActive(false);
                Life2.gameObject.SetActive(false);
                break;

            case 0:
                Life.gameObject.SetActive(false);
                Life1.gameObject.SetActive(false);
                Life2.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }
    }
}
