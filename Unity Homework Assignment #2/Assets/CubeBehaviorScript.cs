using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviorScript : MonoBehaviour
{
    public GameObject SomeObject;
    Rigidbody SomeRigidbody;
    Vector3 PositionOffset;

    private bool correct = true;
    private bool My_Play;

    AudioSource My_AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        PositionOffset = SomeObject.transform.position;
        My_AudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (correct)
        {
            SomeObject.transform.position = new Vector3(0, Mathf.Sin(Time.time) * 10, 0) + PositionOffset;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                My_Play = true;
                My_AudioSource.Play();
            }
            
        }
        else
        {
            My_Play = false;
            My_AudioSource.Stop();
        }
    }
}
