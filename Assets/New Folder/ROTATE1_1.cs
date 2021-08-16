using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class ROTATE1_1 : MonoBehaviour
{

   
    private float Speed = -1f;


  


void Update()
    {
      
        transform.Rotate(0, Speed, 0);
        
    }
}
