using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    private Vector3 respawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            myRigidbody.velocity = Vector2.up * 8;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collison.tag == "FallDetector")
        {
            transform.position.position = respawnPoint;
        }
        else if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
    }
}
