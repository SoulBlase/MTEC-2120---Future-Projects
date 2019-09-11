using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBuilderBehavior : MonoBehaviour
{
    public GameObject CubePrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(CubePrefab, new Vector3(0, 5, 9), Quaternion.identity);
    }

    // Update is called once per frame
    /*void Update()
    {
        
    }*/
}
