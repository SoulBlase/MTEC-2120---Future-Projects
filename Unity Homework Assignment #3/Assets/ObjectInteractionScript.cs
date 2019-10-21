using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractionScript : MonoBehaviour
{
    public GameObject ReferenceObject;

    public GameObject ReferenceObject2;

    private Rigidbody NewRigid;

    public Light lightToChangeColorOf;

    private Vector3 offset;
    private Vector3 scaling;

    public float Timer;
    private bool IsTrue;

    // Start is called before the first frame update
    void Start()
    {
        NewRigid = GetComponent<Rigidbody>();
        offset = ReferenceObject2.transform.position;
        scaling = ReferenceObject2.transform.localScale;
        IsTrue = true;
    }

    // Update is called once per frame
    void Update()
    {
        ReferenceObject.transform.position = Vector3.down * Time.time;
        NewRigid.AddForce(Vector3.up * Time.time);
        
        if (IsTrue)
        {
            Timer = Time.deltaTime;
            ReferenceObject2.transform.position = new Vector3(Mathf.Sin(Time.time ) * 2, 0, 0) + offset;
        }
        
    }
}
