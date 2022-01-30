using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float velocity = 10;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * velocity * 5, 0, 0);
    }
}
