using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleDestroyTrigger : MonoBehaviour
{
    public static bool playerHasPassedDestroyPoint = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player" && !playerHasPassedDestroyPoint)
        {
            Debug.Log("yeet"); 
            playerHasPassedDestroyPoint = true; 
        }
    }
}
