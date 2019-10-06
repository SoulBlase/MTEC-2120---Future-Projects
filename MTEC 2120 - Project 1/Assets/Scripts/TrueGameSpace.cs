using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueGameSpace : MonoBehaviour
{
    public GameObject CubePrefab;

    public Vector3 LookAngle;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(CubePrefab, new Vector3(0, 0, 0), Quaternion.identity);

        Build_A_Wall_At_Z(-1);
        Build_A_Wall_At_Z(-3);
        Build_A_Wall_At_Z2(1);
        Build_A_Wall_At_Z2(3);
        Build_A_Wall_At_X(1);
        Build_A_Wall_At_X(5);
        Build_A_Wall_At_X2(-1);
        Build_A_Wall_At_X2(-5);
        Build_A_Wall_At_Y(1);
        Build_A_Wall_At_Y(5);
        Build_A_Wall_At_Y2(1);
        Build_A_Wall_At_Y2(5);

        if (Input.GetAxis("Mouse X") != 0)
        {
            LookAngle.y += Input.GetAxis("Mouse X");
        }
        if (Input.GetAxis("Mouse Y") != 0)
        {
            LookAngle.x += Input.GetAxis("Mouse Y");
        }

        transform.rotation = Quaternion.Euler(LookAngle);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Build_A_Wall_At_Z(float z)
    {
        for (int XPos = 0; XPos < 20; XPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(CubePrefab, new Vector3(XPos - 10, YPos, 0), Quaternion.identity);
            }
        }
    }

    void Build_A_Wall_At_Z2(float z)
    {
        for(int XPos = 0; XPos < 20; XPos++)
        {
            for(int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(CubePrefab, new Vector3(XPos - 10, YPos , 20), Quaternion.identity);
            }
        }
    }

    void Build_A_Wall_At_X(float x)
    {
        for (int ZPos = 0; ZPos < 20; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(CubePrefab, new Vector3(-10, YPos, ZPos + 1), Quaternion.identity);
            }
        }
    }

    void Build_A_Wall_At_X2(float x)
    {
        for (int ZPos = 0; ZPos < 20; ZPos++)
        {
            for (int YPos = 0; YPos < 10; YPos++)
            {
                Instantiate(CubePrefab, new Vector3(9, YPos, ZPos + 1), Quaternion.identity);
            }
        }
    }

    void Build_A_Wall_At_Y(float y)
    {
        for (int XPos = 0; XPos < 20; XPos++)
        {
            for (int ZPos = 0; ZPos < 20; ZPos++)
            {
                Instantiate(CubePrefab, new Vector3(XPos + -10, 10, ZPos + 1), Quaternion.identity);
            }
        }
    }

    void Build_A_Wall_At_Y2(float y)
    {
        for (int XPos = 0; XPos < 20; XPos++)
        {
            for (int ZPos = 0; ZPos < 20; ZPos++)
            {
                Instantiate(CubePrefab, new Vector3(XPos - 10, 0, ZPos + 1), Quaternion.identity);
            }
        }
    }

}
