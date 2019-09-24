using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//INHERITS FROM ENEMY SCRIPT
public class EnemyWalker : Enemy
{
    private void Update()
    {
        Movement();
        if (ThrowBool.isInRange)
        {
            //enemy attacks after a set amout of seconds
            if (Time.time > lastThrowTime + rateOfThrowing)
            { 
                Attack();
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag != "Ground")
        {
            Flip(); 
        }
    }


}
