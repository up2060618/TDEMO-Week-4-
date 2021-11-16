using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreScript : MonoBehaviour
{

    public static int ScoreCount;
    public Text CurrentScore;

    void Start()
    {
    ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
    CurrentScore.text = ScoreCount.ToString();
       
    if (ScoreCount >= 25)
    {
        ToEndScreen();
    }

    }



public void ToEndScreen()
{
    SceneManager.LoadScene(2);
}

}
