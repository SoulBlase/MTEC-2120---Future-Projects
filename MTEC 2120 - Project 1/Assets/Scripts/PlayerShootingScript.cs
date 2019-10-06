using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootingScript : MonoBehaviour
{
    public Rigidbody Projectile;
    public Transform SpawnPoint;
    Transform cameraTransform;


    public float shootSpeed = 200;
    public float movespeed;
    private float maxspeed = 5f;
    private Vector3 input;


    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {

        input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        /*if(GetComponent<Rigidbody>().velocity.magnitude < maxspeed)
        {
            GetComponent<Rigidbody>().AddForce(input * maxspeed);
        }*/

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody Clone;
            Clone = (Rigidbody)Instantiate(Projectile, SpawnPoint.position, Projectile.rotation);
            Clone.velocity = SpawnPoint.TransformDirection(Vector3.forward * 20);
            
        }
        
    }

    

    //Reflect by Boundary
    /*void OnTriggerEnter(Collider collider)
    {
        Destroy(collider.gameObject);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }*/
}
