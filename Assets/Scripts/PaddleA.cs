using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleA : MonoBehaviour
{

    public float paddleSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0, 1 * paddleSpeed * Time.deltaTime);
            //transform.position = transform.position + new Vector2(0, 1) * Time.deltaTime * paddleSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1 * paddleSpeed * Time.deltaTime);
        }
    }
}
