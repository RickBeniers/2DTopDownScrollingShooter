using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    //private Rigidbody projectile;

    public GameObject projectile;

    private void Start()
    {
        //give the bullet a velocity when fired.
        //GetComponent<Rigidbody>().velocity = new Vector2(0, 20);
        //Debug.Log("A");
    }
    private void Update()
    {
        //if spacebar is pressed
        if (Input.GetKeyDown("Jump"))
        {
            //create new bullet gameobject and give position + speed.
            GameObject go = Instantiate(projectile, transform.position, transform.rotation);
            go.transform.parent = GameObject.Find("ShotCollector").transform;
            go.AddComponent<Rigidbody>();
            go.GetComponent<Rigidbody>().useGravity = false;
            go.GetComponent<Rigidbody>().freezeRotation = true;
            go.GetComponent<Rigidbody>().transform.localScale = new Vector3(0.04f, 0.05f, 1f);
            go.GetComponent<Rigidbody>().velocity = new Vector2(0, 10);


        }
    }
}
