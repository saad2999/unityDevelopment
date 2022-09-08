using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      //  Debug.Log("i am printing from debug");
       // Debug.Log("i am saad");
        //Debug.LogWarning("I am a warning ignore me anyway ");
       // Debug.LogError("I am error, I can make your life hell");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("up key is pressed");
            transform.position += new Vector3(0, 1, 0);
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down key is pressed");
            transform.position+= new Vector3(0, -1, 0);

        }

    }
}
