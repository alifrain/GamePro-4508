using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    Vector3 kekanan;
    Vector3 kekiri;
    Vector3 keatas;
    Vector3 kebawah;
    Vector3 maju;
    Vector3 mundur;

    public int aksi;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3 (1,0,0);
        kekiri = new Vector3 (-1,0,0);
        keatas = new Vector3 (0,1,0);
        maju = new Vector3(0,0,1);
        mundur = new Vector3(0,0,-1);


    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("right"))
        transform.position = transform.position + (kekiri * 3 * Time.deltaTime);
        if(Input.GetKey("left"))
        transform.position = transform.position + (kekanan * 3 * Time.deltaTime);
        if(Input.GetKey("up"))
        transform.position = transform.position + (keatas * 3 * Time.deltaTime);

    } 
    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "enemyTag"){
            Debug.Log ("Game Over");
            Time.timeScale = 0;
        }
        if(coll.gameObject.tag == "coinTag"){
            Debug.Log ("Score anda : "+ score);
            score = score + 1;

        }
    }
    void OnCollisionStay2D(Collision2D coll){
        if(coll.gameObject.tag == "playerTag"){
            Debug.Log ("Sedang Nabrak");
        }

    }
    void OnCollisionExit2D(Collision2D coll) {
        if(coll.gameObject.tag == "enemyTag"){
            Debug.Log ("Sudah Nabrak");
        }
    }
}
   