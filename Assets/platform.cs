using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    // Start is called before the first frame update
    int ValuetoSend = 12;
    void Start()
    {
        string valuefromFunction = FindObjectOfType<Cube>().PrintingfromoutSide(ValuetoSend);
        Debug.Log(valuefromFunction);

    }

    // Update is called once per frame
    void Update()
    {

    }

}