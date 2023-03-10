using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballForce = 2f;
    public Rigidbody2D rb;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        float random1 = Random.Range(-5, 5); 
        int random2 = Random.Range(-2, 2);

        if(random1 == 0)
            random1 = 2;
        if (random2 == 0)
            random2 = 2;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(random1, random2).normalized * ballForce, ForceMode2D.Impulse);
    }

}
