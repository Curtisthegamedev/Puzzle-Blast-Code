using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPuzzle : MonoBehaviour
{
    private IEnumerator WaitAndDestroyPuzzle()
    {
        yield return new WaitForSeconds(10);
        Destroy(this.gameObject); 
    }
    private void Update()
    {
        if (PuzzleDestroyTrigger.playerHasPassedDestroyPoint)
        {
            StartCoroutine(WaitAndDestroyPuzzle());
        }
    }
}
