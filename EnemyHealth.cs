using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //enemys int health value 
    private int health;
    //this is the enemy's health bar
    [SerializeField] RectTransform MushroomHealthBar;
    //this variable is used to set the size of the health bar. 
    private int scale;

    private void Start()
    {
        health = 5; 

        if(MushroomHealthBar)
        {
            //set the scale size of the health bar to go down when health is taken away
            scale = (int)MushroomHealthBar.sizeDelta.x / health; 
        }
    }

    private void OnCollisionEnter2D(Collision2D c)
    {
        //if the enemy collides with the ball they lose health 
        if(c.gameObject.tag == "MyBall")
        {
            health = health - 1; 
        }
        
        //chnages the healthbar size dependin on the scale variable and health variable
        MushroomHealthBar.sizeDelta = new Vector2(health * scale, MushroomHealthBar.sizeDelta.y); 
    }

    private void Update()
    {
        //kill the enemy is their health is zero. 
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "SwordWeapon")
        {
            health = health - 3;
            Debug.Log(health); 
        }

        MushroomHealthBar.sizeDelta = new Vector2(health * scale, MushroomHealthBar.sizeDelta.y);

    }
}
