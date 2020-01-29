using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public Score scoreManager;
    public int value;

    private void OnCollisionEnter(Collision collision)
    {
        scoreManager.AddPoint(value);

        Debug.Log("Collision Detected");
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}