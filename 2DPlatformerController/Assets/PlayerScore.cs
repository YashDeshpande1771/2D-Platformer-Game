using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int collectableCount;
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Collectable")
        {
            target.gameObject.SetActive(false);
            collectableCount++;
            ScoreScript.scoreValue += 50;
        }
    }

    void Start()
    {
        
    }
}

