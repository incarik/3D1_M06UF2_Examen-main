using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0, 0);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0, 0);
        }
         if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, speed, 0);
        }
    }
}
