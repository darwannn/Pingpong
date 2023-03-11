using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballForce = 1f;
    public Rigidbody2D rb;
    // Start is called before the first frame update


    void Start()
    {
        transform.position = new Vector3(0, 0, 0);

        int random1 = Random.Range(-5, 5);
        int random2 = Random.Range(-5, 5);
        rb = GetComponent<Rigidbody2D>();
        
       rb.AddForce(new Vector2(1, random2).normalized * ballForce, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
