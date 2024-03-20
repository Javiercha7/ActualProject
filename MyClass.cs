using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 CurrentRespawnPoint;



    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Cat"))
        {
            CurrentRespawnPoint = transform.position;
        }
    }
}