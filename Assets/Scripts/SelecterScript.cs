using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelecterScript : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bound")
        {
            Destroy (this.gameObject);
        }
        if (other.tag == "WhitePiece")
        {
            Destroy(this.gameObject);
        }
        if (other.tag == "BlackPiece")
        {
            Destroy(this.gameObject);
        }
    }
}
