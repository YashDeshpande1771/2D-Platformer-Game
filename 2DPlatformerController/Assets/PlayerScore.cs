using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // Start is called before the first frame update
    public static int collectibleCount = 0;
    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag != "Collectible")
        {
            return;
        }
        target.gameObject.SetActive(false);
        collectibleCount++;
        ScoreScript.scoreValue += 50;
    }
}

