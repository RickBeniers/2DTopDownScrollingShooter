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
    public GameObject fireEffect;
    public GameObject music;

    public AudioClip soundEffect06;

    private void Start()
    {
        //give the bullet a velocity when fired.
        //GetComponent<Rigidbody>().velocity = new Vector2(0, 20);
        //Debug.Log("A");s
        
    }
    private void Update()
    {
        //if spacebar is pressed execute ShootBullet script.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            shooting = true;
            fireEffect.SetActive(true);
            music.GetComponent<MusicController>().explosionSoundController(6);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            shooting = false;
            fireEffect.SetActive(false);
            music.GetComponent<MusicController>().shootingAudioSource.Stop();
            //Debug.Log("stop shooting sound");
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
            go.GetComponent<Rigidbody2D>().gravityScale = 0;
            //freeze rotation.
            go.GetComponent<Rigidbody2D>().freezeRotation = true;
            //set the scale of the object.
            go.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(0.04f, 0.05f, 1f);
            //set the speed of the object.
            go.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 6);
            //switch collision detection mode
            //go.GetComponent<Rigidbody2D>().collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
            //give the object the tag bullet
            go.tag = "PlayerBulletTag";
            
            //increse the Int variable bulletsFired.
            bulletsFired++;
            Destroy(go, 10f);
        
    }
    
}

