using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyDroneDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EnemyFlyDrone.playerIsNear = true; 
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EnemyFlyDrone.playerIsNear = false; 
        }
    }
}
