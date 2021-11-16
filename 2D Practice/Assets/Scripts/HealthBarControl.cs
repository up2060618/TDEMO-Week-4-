using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarControl : MonoBehaviour
{
    public GameObject FullLife, TwoLife, OneLife, gameOver;
    public static int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        FullLife.gameObject.SetActive(true);
        TwoLife.gameObject.SetActive(false);
        OneLife.gameObject.SetActive(false);
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
                FullLife.gameObject.SetActive(true);
                
                break;

            case 2:
                FullLife.gameObject.SetActive(false);
                TwoLife.gameObject.SetActive(true);
                
                break;

            case 1:
                TwoLife.gameObject.SetActive(false);
                OneLife.gameObject.SetActive(true);
                
                break;

            case 0:
                OneLife.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;

        }
    }
}
