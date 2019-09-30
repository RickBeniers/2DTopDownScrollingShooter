using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    //private GameObject Detection;
    public GameObject EnemyBullet;

    // Start is called before the first frame update
    void Start()
    {
        //Detection = GameObject.Find("DetectionArea");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyShooting(bool PlayerDetected)
    {
        if (PlayerDetected == true)
        {
            //Debug.Log("pulling the trigger");
            ShootBullet();
        }
    }
    public void ShootBullet()
    {
        //Debug.Log("Shooting!");
        GameObject go = Instantiate(EnemyBullet, transform.position, Quaternion.identity);
        //Debug.Log("shot" + go.name);
        go.transform.parent = GameObject.Find("EnemyShotCollector").transform;
        go.GetComponent<Rigidbody2D>().freezeRotation = true;
        go.GetComponent<Rigidbody2D>().gravityScale = 0;
        go.GetComponent<Rigidbody2D>().transform.localScale = new Vector3(0.04f, 0.05f, 1f);
        go.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -6);
        go.tag = "EnemyBulletTag";
        Destroy(go, 10f);
    }
}
