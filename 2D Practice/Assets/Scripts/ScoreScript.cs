using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{

    public int ScoreCount;
    public Text CurrentScore;

    void Start()
    {
    ScoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
    CurrentScore.text = ScoreCount.ToString();

    }
}
