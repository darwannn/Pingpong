using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleA : MonoBehaviour
{

    public float paddleSpeed = 5f;

    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            transform.position += new Vector3(0, 1 * paddleSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -1 * paddleSpeed * Time.deltaTime);
        }
    }
}
