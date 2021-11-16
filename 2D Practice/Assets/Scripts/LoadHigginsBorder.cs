using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadHigginsBorder : MonoBehaviour
{
    public GameObject HigginsBorder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > HigginsAI.spawnTime + 8)
        {
            HigginsBorder.SetActive(true);
        }
    }
}
