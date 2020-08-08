using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private int bounces;
    private int maxBounces;

    // Start is called before the first frame update
    void Start()
    {
        bounces = 0;
        maxBounces = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (bounces == maxBounces)
            gameObject.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Wall")
            bounces++;

        if (collision.gameObject.tag == "Projectile")
        {
            collision.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "Player")
        { 
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "StaticEnnemy" || collision.gameObject.tag == "MobileEnnemy")
        {
            Ennemy.ennemies--;
            gameObject.SetActive(false);
            collision.gameObject.SetActive(false);
        }
    }
}
