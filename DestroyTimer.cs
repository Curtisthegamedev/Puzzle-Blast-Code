using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class DestroyTimer : MonoBehaviour
{
    private float timer = 100.0f;

    private void Start()
    {
        Destroy(gameObject, timer); 
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag != "Ground" && c.gameObject.tag != "player")
        {
            Destroy(gameObject); 
        }
        else if(c.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("GameOver"); 
        }
    }
}
