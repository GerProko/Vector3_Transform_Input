using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{

    public Vector3 movementVector;
    public GameObject myCube;


    void Start()
    {
      
    }

    void Update()
    {
        if (Mathf.Abs(myCube.transform.position.x) < 8)
        {
            myCube.transform.position -= movementVector;

        }
    }
}
