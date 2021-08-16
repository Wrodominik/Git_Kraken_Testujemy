using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE : MonoBehaviour
{
    private float Speed = 1f;


    void Update()
    {
        transform.Rotate(0, 0, Speed);
        
    }
}
