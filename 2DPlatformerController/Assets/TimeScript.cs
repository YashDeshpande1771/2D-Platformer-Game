using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    public static int numberOfCollectables;
   
   
    void Start()
    {
        textBox = GetComponent<Text>();
        timeStart = Time.time;       
        numberOfCollectables = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
        textBox.text = "Time: " + Mathf.Round( Time.time - timeStart).ToString();
        if(PlayerScore.collectableCount == numberOfCollectables)
        {
            textBox.text = "Finished in " + Mathf.Round(Time.time - timeStart).ToString() + " seconds";
            Time.timeScale = 0;
        }
    }
}