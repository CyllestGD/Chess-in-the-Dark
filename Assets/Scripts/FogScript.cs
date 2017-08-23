using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FogScript : MonoBehaviour {
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "WhitePiece")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
        if (other.tag == "BlackPiece")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "WhitePiece")
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
        if (other.tag == "BlackPiece")
        {
            gameObject.GetComponent<Renderer>().enabled = true;
        }
    }
    void OnMouseDown()
    {
        Debug.Log("The Fog Collider is TOO DAMN HIGH!");
    }
}
