using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public static int ennemies = 0;
    private RaycastHit hit;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "MobileEnnemy")
        {
            transform.Translate(Vector3.right * 5 * Time.deltaTime);
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit,5))
            {
                transform.Rotate(Vector3.up * Random.Range(50, 200));
            }
        }
    }
}
