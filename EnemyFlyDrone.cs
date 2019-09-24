using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFlyDrone : MonoBehaviour
{
    [SerializeField] float Speed;
    private Transform targetPlayer;
    [SerializeField] Transform randomTarget; 
    [SerializeField] float timer;
    private float turntimer = 10;
    public static bool NextTurn = false;
    private bool isMoveing;
    private float moveDuration = 3f;
    private float stayDuration = 2f;
    public static bool playerIsNear = false; 
    Vector3 startPosition;
    void Awake()
    {
        startPosition = transform.position;
    }


    void Start()
    {
        //at the beggining I set the timer to 0 and the targetPlayer Transform variable to my Player game object(The heart). 
        targetPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //randomTarget = GameObject.FindGameObjectWithTag("RanTarget").GetComponent<Transform>(); 
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //I call my move to player and update functions here so that 
        MoveToPlayer();
        UpdateTimer();
    }

    void MoveToPlayer()
    {
        //This is where I create my Move to player method. 

        //I use a bool variable, if statements and a timer float variable to change to the players turn when the enemy turn lasts for ten seconds.   
        if (isMoveing == true && playerIsNear && !Player.isInvisable)
        {
            //transforms the attacks position to chase the player. 
            transform.position = Vector2.MoveTowards(transform.position, targetPlayer.position, Speed * Time.deltaTime);
        }
        else if (isMoveing == true && !playerIsNear || Player.isInvisable)
        {
            transform.position = Vector2.MoveTowards(transform.position, randomTarget.position, Speed * Time.deltaTime); 
        }
        else if (turntimer >= 10)
        {
            NextTurn = true;
        }

    }
    //Updates another timer variable so that the enemy attack will stop for a few seconds every 3 seconds. 
    void UpdateTimer()
    {
        timer += Time.deltaTime;
        turntimer += Time.deltaTime;
        if (isMoveing == true)
        {
            if (timer > moveDuration)
            {
                timer = 0;
                isMoveing = false;
            }
        }

        if (isMoveing == false)
        {
            if (timer > stayDuration)
            {
                timer = 0;
                isMoveing = true;
            }


        }
    }
    //creates a function to reset the enemy atack to it's original Position
    public void ResetItem()
    {
        gameObject.SetActive(true);
        transform.position = startPosition;
    }
}
