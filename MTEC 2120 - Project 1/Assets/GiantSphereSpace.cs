using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiantSphereSpace : MonoBehaviour
{
    public Vector3 LookAngle;

    // Start is called before the first frame update
    void Start()
    {
        //widen the sphere
        transform.localScale += new Vector3(50, 50, 50);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse X") != 0)
        {
            
        }
    }
}
