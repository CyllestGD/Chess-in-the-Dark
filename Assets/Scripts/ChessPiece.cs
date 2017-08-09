using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChessPiece : MonoBehaviour
{
    public bool isWhite;

    void OnTriggerEnter(Collider2D other)
    {
        if (other.tag == "Fog")
        {
            other.gameObject.getcomponent<Renderer>().enabled = true;
        }

    }
}
