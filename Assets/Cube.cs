using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D Myrigidbody2D;
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
            Myrigidbody2D.velocity = new Vector2(0f, 10f);
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("down key is pressed");
            Myrigidbody2D.velocity = new Vector2(0f, -10f);



        }if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("right key is pressed");
            Myrigidbody2D.velocity = new Vector2(10f, 0f);



        }if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("left key is pressed");
            Myrigidbody2D.velocity = new Vector2(-10f, 0f);



        }

    }
}
