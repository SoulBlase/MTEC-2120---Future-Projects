using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            //Grab original position
            Vector3 SpheresNextPosition = transform.position;
            //Modify position
            SpheresNextPosition.y = Mathf.Sin(Time.time) * 3;
            //Apply position
            transform.position = SpheresNextPosition;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            Vector3 SpheresNextPosition = transform.position;
            SpheresNextPosition.y = Mathf.Sin(Time.time) * -3;
            transform.position = SpheresNextPosition;
        }
        else
        {
            Debug.Log("I stopped moving for one frame");
        }
    }
}
