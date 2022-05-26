using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chainMovement : MonoBehaviour
{
    public float chainSpeed = 0.05f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * chainSpeed;

        if (transform.position.x > 100)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
