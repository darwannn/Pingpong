using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutBounds : MonoBehaviour
{
    [SerializeField]
    GameObject ballPrefab;

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Add points
        Destroy(other.gameObject);
        Instantiate(ballPrefab);
    }
}
