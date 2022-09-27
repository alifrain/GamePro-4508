using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movespeed;
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > transform.position.x)
            transform.position = new Vector3 (transform.position.x + movespeed * Time.deltaTime, transform.position.y);
            
    }
}
