using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaMovimiento : MonoBehaviour
{
    public float zSpeed;
    public bool toRight;

    public GameObject prefabSphere;
    public GameObject prefabCylinder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toRight == true)
        {
        transform.position -= new Vector3(0, 0, zSpeed);
        }
        else
        {
        transform.position += new Vector3(0, 0, zSpeed);
        }
        if (transform.position.z > 3)
        {
            toRight = true;
            Instantiate(prefabSphere);
        }
        if (transform.position.z < -3)
        {
            toRight = false;
            Instantiate(prefabCylinder);
        }
    }
}
