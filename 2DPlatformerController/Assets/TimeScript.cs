using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    private float timeStart = 0;
    private Text textBox = null;
    private const int numberOfCollectibles = 4;

   private void Start()
    {
        textBox = GetComponent<Text> ();
        timeStart = Time.time;       
    }

    void Update()
    {
        textBox.text = "Time: " + Mathf.Round(Time.time - timeStart).ToString();
        if(PlayerScore.collectibleCount == numberOfCollectibles)
        {
            textBox.text = "Finished in " + Mathf.Round(Time.time - timeStart).ToString() + " seconds";
            Time.timeScale = 0;
        }
    }
}