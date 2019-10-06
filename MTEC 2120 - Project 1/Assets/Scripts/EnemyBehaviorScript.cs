using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorScript : MonoBehaviour
{
    

    public GameObject EnemyPrefab;
    public GameObject Clone;

    Vector3 RandomPos;

    // Start is called before the first frame update
    void Start()
    {
        RandomPos.x = 8;
        RandomPos.y = 11;
        RandomPos.z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Clone = (GameObject)Instantiate(EnemyPrefab, RandomPos, Quaternion.identity);
    }

    
}
