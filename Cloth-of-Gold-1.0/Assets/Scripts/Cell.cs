using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int numNeighbors = 0;

    public void SetAlive(bool alive)
    {
        isAlive = alive;
        if (alive)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            GetComponent<SpriteRenderer>().sortingOrder = 100;
        }

        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<SpriteRenderer>().sortingOrder = 100;
        }

    }
}
