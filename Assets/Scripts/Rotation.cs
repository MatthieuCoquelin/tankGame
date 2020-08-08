using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Rigidbody projectile;
    public Transform origine;
    private int speed = 500, speedDouble = 750;
    private float randAngle = 100;

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player")
        {
            var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
            var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.down);

            if (Input.GetButtonDown("Fire1"))
            {
                InstantiateProjectile(speed);
            }
        }


        if (gameObject.tag == "Green")
        {
            randAngle = Rand(0.0f, 100f);
            if (randAngle <= 0.5f)
            {
                Shoot(speedDouble);
            }
        }

        if (gameObject.tag == "Pink")
        {
            randAngle = Rand(0.0f, 100f);
            if (randAngle <= 0.5f)
            {
                Shoot(speed);
            }
        }

        if (gameObject.tag == "White")
        {
            randAngle = Rand(0.0f, 100f);
            if (randAngle <= 0.5f)
            {
                Shoot(speed);
            }
        }
    }

    void Shoot(int projectileSpeed)
    {
        float angle = Rand(0.0f, 360.0f);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.down);

        InstantiateProjectile(projectileSpeed);
    }

    void InstantiateProjectile(int strenght)
    {
        Rigidbody instance;
        instance = Instantiate(projectile, origine.position, origine.rotation) as Rigidbody;
        instance.AddForce(-origine.up * strenght);
    }

    float Rand(float min, float max)
    {
        return Random.Range(min, max);
    }
}
