using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    private float TimeStart = 0;
    private Text textBox = null;
    private const int numberOfCollectables = 4;

     void Start()
    {
        textBox = GetComponent<Text> ();
        TimeStart = Time.time;       
    }

    void Update()
    {
        textBox.text = "Time: " + Mathf.Round(Time.time - TimeStart).ToString();
        if(PlayerScore.collectibleCount == numberOfCollectables)
        {
            textBox.text = "Finished in " + Mathf.Round(Time.time - TimeStart).ToString() + " seconds";
            Time.timeScale = 0;
        }
    }
}