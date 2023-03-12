using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballForce = 1f;
    public Rigidbody2D rb;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        float random1 = Random.Range(0, 2) == 0 ? -1:1;
        int random2 = Random.Range(0, 2) == 0 ? -1:1;
        rb = GetComponent<Rigidbody2D>();
        
        rb.AddForce(new Vector2(random1, random2).normalized * ballForce, ForceMode2D.Impulse);
    }

}
