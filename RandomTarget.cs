using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(ranPosWithDelay());
    }

    IEnumerator ranPosWithDelay()
    {
        while (true)
        {
            SetPosition();
            yield return new WaitForSeconds(2);
        }
    }

    void SetPosition()
    {
        transform.position = new Vector3(Random.Range(29, 98), Random.Range(3, 10), 0);
    }
}
