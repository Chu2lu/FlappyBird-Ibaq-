using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float sd=1;
    private void Start()
    {
        Destroy(gameObject,7);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left * sd * Time.deltaTime;
    }
}
