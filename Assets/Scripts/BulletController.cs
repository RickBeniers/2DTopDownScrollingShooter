using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    //private Rigidbody projectile;

    public GameObject projectile;
    [SerializeField]
    private bool shooting;
    [SerializeField]
    private int bulletsFired;

    private void Start()
    {
        //give the bullet a velocity when fired.
        //GetComponent<Rigidbody>().velocity = new Vector2(0, 20);
        //Debug.Log("A");
        
    }
    private void Update()
    {
        //if spacebar is pressed execute ShootBullet script.
        if (Input.GetButton("Jump"))
        {
            shooting = true;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            shooting = false;
        }
        if (shooting == true)
        {
            ShootBullet();
        }
    }
    private void ShootBullet()
    {
        
            //create new bullet gameobject and give position.
            GameObject go = Instantiate(projectile, transform.position, transform.rotation);
            //asign the instantiated object to a parent object.
            go.transform.parent = GameObject.Find("ShotCollector").transform;
            //go.AddComponent<Rigidbody>();
            //set the gravity to false.
            go.GetComponent<Rigidbody>().useGravity = false;
            //freeze rotation.
            go.GetComponent<Rigidbody>().freezeRotation = true;
            //set the scale of the object.
            go.GetComponent<Rigidbody>().transform.localScale = new Vector3(0.04f, 0.05f, 1f);
            //set the speed of the object.
            go.GetComponent<Rigidbody>().velocity = new Vector2(0, 6);
            //give the object the tag bullet
            go.tag = "Bullet";
            //increse the Int variable bulletsFired.
            bulletsFired++;
        
    }
}

