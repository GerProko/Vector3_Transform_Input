using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPosition : MonoBehaviour
{

    public Vector3 newPosition;
    public GameObject myCube;

    void Start()
    {
        myCube.transform.position = newPosition;
    }

    void Update()
    {
        
    }
}
