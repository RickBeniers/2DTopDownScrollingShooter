using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    [SerializeField]
    private GameObject[] enemies;
    [SerializeField]
    private Vector3 spawnValues;
    [SerializeField]
    private float spawnWait;
    [SerializeField]
    private float spawnMostWait;
    [SerializeField]
    private float spawnLeastWait;
    [SerializeField]
    private int startWait;
    [SerializeField]
    private bool stop;
    [SerializeField]
    private int randEnemy;
    [SerializeField]
    private int SpawnedEnemies;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
    }
    //call routine to spawn objects over and over again.
    IEnumerator WaitSpawner()
    {
        yield return new WaitForSeconds(startWait);
        while (!stop)
        {
            //choose randomly which enemy is going to be picked for spawning.
            randEnemy = Random.Range(0, 2);
            //choose a random position for the enemy.
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(-spawnValues.y, spawnValues.y), -1.5f);
            //instantiate the enemy.
            GameObject go = Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            go.transform.parent = GameObject.Find("EnemyCollector").transform;
            go.GetComponent<Rigidbody2D>().freezeRotation = true;
            go.GetComponent<Rigidbody2D>().gravityScale = 0;
            SpawnedEnemies++;
            //wait for the timer to completed to spawn again.
            yield return new WaitForSeconds(spawnWait);
        }

    }
}
