using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCycler : MonoBehaviour
{
    public GameObject[] modelArray;
    private int modelNumber;

    private float nextActionTime = 0.0f;
    public float period = 0.1f;

    void Start()
    {
        modelNumber = 0;
        ModelSwitch();
    }

    void ModelSwitch()
    {
        for (int x = 0; x < modelArray.Length; x++)
        {
            if (x == modelNumber)
            {
                modelArray[x].SetActive(true);
            }
            else
            {
                modelArray[x].SetActive(false);
            }
        }
        modelNumber += 1;
        if (modelNumber > modelArray.Length - 1)
        {
            modelNumber = 0;
        }
    }

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            // execute block of code here
            ModelSwitch();
        }
    }
}