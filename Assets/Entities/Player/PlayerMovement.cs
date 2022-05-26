using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(1, 0, 0) * speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-1, 0, 0) * speed;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, 1, 0) * speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -1, 0) * speed;
        }
        
        float PlayerX = Mathf.Clamp(transform.position.x, -71, 71);
        transform.position = new Vector3(PlayerX, transform.position.y, transform.position.z);
        float PlayerY = Mathf.Clamp(transform.position.x, -54, 54);
        transform.position = new Vector3(transform.position.x, PlayerY, transform.position.z);
        //-54, 54

    }
}