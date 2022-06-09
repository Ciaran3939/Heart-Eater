using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainMovement : MonoBehaviour
{
    public bool MovingRight = true;
    public float chainSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MovingRight)
        {
            transform.position += new Vector3(1, 0, 0) * chainSpeed;
        }
        
        if (!MovingRight)
        {
            transform.position += new Vector3(-1, 0, 0) * chainSpeed;
        }

        if (transform.position.x > 100)
        {
            MovingRight = false;
        }

        if (transform.position.x < -100)
        {
            Destroy(gameObject);
        }
    }
}
