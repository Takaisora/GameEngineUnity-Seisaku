using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //IDO
        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.position += transform.right;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position -= transform.right;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += transform.forward;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position -= transform.forward;
        }
        
    }
}
