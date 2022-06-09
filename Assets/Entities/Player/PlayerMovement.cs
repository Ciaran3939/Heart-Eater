using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 0.05f;
    public GameObject chainPrefab;
    public static int Health = 10;

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
        float PlayerY = Mathf.Clamp(transform.position.y, -54, 54);
        transform.position = new Vector3(transform.position.x, PlayerY, transform.position.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Chain");
            Instantiate(chainPrefab, transform.position, Quaternion.identity);
        }

        void OnTriggerEnter2D(Collider2D collision)
        {
            if (Health < 0)
            {
                Health--;
                Application.LoadLevel("Lose");
            }
        }
    }
}