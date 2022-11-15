using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInAct : MonoBehaviour
{
    public Vector2 veloc = new Vector2(0,0);
    // Start is called before the first frame update
    float range = 2;
    void Start()
    {
        GetComponent<Rigidbody2D> ().velocity = veloc;
        transform.position= new Vector3 (transform.position.x,
        transform.position.y - range * Random.value,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}