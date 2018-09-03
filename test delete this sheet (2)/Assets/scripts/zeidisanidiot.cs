using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeidisanidiot : MonoBehaviour
{
    public float x;
    public float rng;
    public float speed;
    // Use this for initialization
    void Start()
    {
        x = transform.position.x;
        speed = 6f;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == x)
        {
            rng = Random.Range(-1, 1);
        }
        if (transform.position.x > x + 7)
        {
            rng = -1;
        }
        if (transform.position.x < x - 7)
        {
            rng = 1;
        }
        transform.Translate(Vector3.right * rng * speed * Time.deltaTime);
    }
}
