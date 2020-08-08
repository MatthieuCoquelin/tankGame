using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 10;
    public float turnSpeed = 50f;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.S))
            transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}